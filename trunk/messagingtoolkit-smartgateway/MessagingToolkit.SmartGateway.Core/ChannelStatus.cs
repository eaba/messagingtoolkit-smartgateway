//===============================================================================
// OSML - Open Source Messaging Library
//
//===============================================================================
// Copyright © TWIT88.COM.  All rights reserved.
//
// This file is part of Open Source Messaging Library.
//
// Open Source Messaging Library is free software: you can redistribute it 
// and/or modify it under the terms of the GNU General Public License version 3.
//
// Open Source Messaging Library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this software.  If not, see <http://www.gnu.org/licenses/>.
//===============================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using log4net;

using MessagingToolkit.Core;
using MessagingToolkit.SmartGateway.Core.Data.ActiveRecord;
using MessagingToolkit.SmartGateway.Core.Properties;
using MessagingToolkit.SmartGateway.Core.Helper;
using MessagingToolkit.SmartGateway.Core.ViewModel;
using MessagingToolkit.SmartGateway.Core.Interprocess;

namespace MessagingToolkit.SmartGateway.Core
{
    /// <summary>
    /// Channel status
    /// </summary>
    public partial class ChannelStatus : UserControl
    {
        // Static Logger
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

                /// <summary>
        /// Service event listener URL
        /// </summary>
        private string serviceEventListenerUrl = AppConfigSettings.GetString(ConfigParameter.ServiceEventListener, ModuleName.Service);


        /// <summary>
        /// Default polling interval
        /// </summary>
        private static int ChannelPollingInterval = AppConfigSettings.GetInt(ConfigParameter.ChannelPollingInterval);


        /// <summary>
        /// Poller for the channels
        /// </summary>
        private Thread channelPoller;

        /// <summary>
        /// Callback method to set the messages
        /// </summary>
        private delegate void SetListCallback();


        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatus"/> class.
        /// </summary>
        public ChannelStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ChannelStatus control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ChannelStatus_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            SetupView();
            RefreshView();
            StartPoller();
        }


        /// <summary>
        /// Setups the view.
        /// </summary>
        private void SetupView()
        {             
            this.olvColChannelName.AspectGetter = delegate(object x) { return ((ChannelStatusView)x).Name; };
            this.olvColPort.AspectGetter = delegate(object x) { return ((ChannelStatusView)x).Port; };
            this.olvColOperator.AspectGetter = delegate(object x) { return ((ChannelStatusView)x).Operator; };
            this.olvColSignalStrength.AspectGetter = delegate(object x) { return ((ChannelStatusView)x).SignalStrength; };
            this.olvColStatus.AspectGetter = delegate(object x) { return ((ChannelStatusView)x).Status; };
        }

        /// <summary>
        /// Refreshes the view.
        /// </summary>
        private void RefreshView()
        {
            if (this.lvwChannelStatus.InvokeRequired)
            {
                SetListCallback callback = new SetListCallback(RefreshView);
                this.Invoke(callback);
            }
            else
            {
                List<ChannelStatusView> channels = new List<ChannelStatusView>();
                foreach (GatewayConfig gwConfig in GatewayConfig.All().OrderBy(gw => gw.Id))
                {
                    ChannelStatusView channel = new ChannelStatusView();
                    channel.Name = gwConfig.Id;
                    channel.Port = gwConfig.ComPort;
                    channels.Add(channel);
                }

                lvwChannelStatus.BeginUpdate();
                lvwChannelStatus.SetObjects(channels);
                lvwChannelStatus.EndUpdate();
                lvwChannelStatus.Refresh();
            }            
        }

        /// <summary>
        /// Starts the poller.
        /// </summary>
        private void StartPoller()
        {
            StopPoller();

            // Check for message every 5 seconds, starting now
            channelPoller = new Thread(new ThreadStart(CheckChannels));
        }

        /// <summary>
        /// Stops the poller.
        /// </summary>
        private void StopPoller()
        {
            if (channelPoller != null)
            {
                try
                {                   
                    channelPoller.Abort();

                }
                catch (Exception) { }
                channelPoller = null;
            }
        }


        /// <summary>
        /// Checks the channels.
        /// </summary>
        private void CheckChannels()
        {
            try
            {
                foreach (GatewayConfig gwConfig in GatewayConfig.All().OrderBy(gw => gw.Id))
                {
                    try
                    {
                        EventAction action = new EventAction(StringEnum.GetStringValue(EventNotificationType.QueryGatewayStatus));
                        action.ActionType = EventAction.Synchronous;
                        action.Values.Add(EventParameter.GatewayId, gwConfig.Id);
                        EventResponse response = RemotingHelper.NotifyEvent(serviceEventListenerUrl, action);
                    }
                    catch (Exception ex)
                    {
                        log.Error(string.Format("Error checking channel - [{0}]", gwConfig.Id));
                        log.Error(ex.Message, ex);
                    }
                }
                Thread.Sleep(ChannelPollingInterval);

            }
            catch (Exception ex)
            {               
                log.Error(ex.Message, ex);
            }
        }
    }
}
