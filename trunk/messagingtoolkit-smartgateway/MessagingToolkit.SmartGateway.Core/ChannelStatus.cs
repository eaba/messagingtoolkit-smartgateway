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

using MessagingToolkit.Core;
using MessagingToolkit.SmartGateway.Core.Data.ActiveRecord;
using MessagingToolkit.SmartGateway.Core.Properties;
using MessagingToolkit.SmartGateway.Core.Helper;
using MessagingToolkit.SmartGateway.Core.ViewModel;

namespace MessagingToolkit.SmartGateway.Core
{
    /// <summary>
    /// Channel status
    /// </summary>
    public partial class ChannelStatus : UserControl
    {
        /// <summary>
        /// Service event listener URL
        /// </summary>
        private string serviceEventListenerUrl = AppConfigSettings.GetString(ConfigParameter.ServiceEventListener, ModuleName.Service);


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
}
