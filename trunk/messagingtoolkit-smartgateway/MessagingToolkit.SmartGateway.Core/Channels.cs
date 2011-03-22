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

using MessagingToolkit.SmartGateway.Core.Data.ActiveRecord;
using MessagingToolkit.SmartGateway.Core.Properties;
using MessagingToolkit.SmartGateway.Core.Helper;

namespace MessagingToolkit.SmartGateway.Core
{
    /// <summary>
    /// Channels control
    /// </summary>
    public partial class Channels : UserControl
    {

        #region // -------------- Event ------------------

        /// <summary>
        /// Occurs when a new gateway added.
        /// </summary>
        public event NewGatewayEventHandler GatewayAdded;

        /// <summary>
        /// Occurs when a gateway is deleted.
        /// </summary>
        public event DeleteGatewayEventHandler GatewayRemoved;

      
        #endregion  // ----------------- Event ------------



        /// <summary>
        /// Initializes a new instance of the <see cref="Channels"/> class.
        /// </summary>
        public Channels()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lnkAddChannel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lnkAddChannel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGateway gatewayForm = new frmGateway();
            gatewayForm.GatewayAdded += new NewGatewayEventHandler(gatewayForm_GatewayAdded);
            DialogResult result = gatewayForm.ShowDialog();

            // Autoresize 
            this.lvwChannels.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// Gateways the form_ gateway added.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void gatewayForm_GatewayAdded(object sender, GatewayEventHandlerArgs e)
        {
            GatewayConfig newChannel = GatewayConfig.SingleOrDefault(g => g.Id == e.GatewayId);
            this.lvwChannels.AddObject(newChannel);
            if (GatewayAdded != null)
            {
                // Raise the event
                GatewayEventHandlerArgs arg = new GatewayEventHandlerArgs(e.GatewayId);
                this.GatewayAdded.BeginInvoke(this, arg, new AsyncCallback(this.AsyncCallback), null);
            }
        }

        /// <summary>
        /// Asynchronous callback method
        /// </summary>
        /// <param name="param">Result</param>
        private void AsyncCallback(IAsyncResult param)
        {
            System.Runtime.Remoting.Messaging.AsyncResult result = (System.Runtime.Remoting.Messaging.AsyncResult)param;
            if (result.AsyncDelegate is NewGatewayEventHandler)
            {
                ((NewGatewayEventHandler)result.AsyncDelegate).EndInvoke(result);
            } else if (result.AsyncDelegate is DeleteGatewayEventHandler)
            {
                ((DeleteGatewayEventHandler)result.AsyncDelegate).EndInvoke(result);
            }
            else 
            {
            }
        }

        /// <summary>
        /// Handles the Load event of the Channels control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Channels_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            ShowChannels();           
        }

        /// <summary>
        /// Shows the channels.
        /// </summary>
        private void ShowChannels()
        {
            lvwChannels.BeginUpdate();

            this.olvColumn1.ImageGetter = delegate(object row)
            {
                return 1;
            };
            this.olvColumn1.AspectGetter = delegate(object x) { return ((GatewayConfig)x).Id; };
            this.olvColumn2.AspectGetter = delegate(object x) { return ((GatewayConfig)x).ComPort; };
            this.olvColumn3.AspectGetter = delegate(object x) { return ((GatewayConfig)x).BaudRate; };
            this.olvColumn4.AspectGetter = delegate(object x) { return Resources.MsgTypeSms; };
            this.olvColumn5.AspectGetter = delegate(object x) { return Resources.ProtocolTypeGsm; };

            lvwChannels.SetObjects(GatewayConfig.All());
            lvwChannels.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwChannels.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);

            lvwChannels.EndUpdate();

        }

        /// <summary>
        /// Handles the Click event of the deleteChannelToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void deleteChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteChannel();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lnkDeleteChannel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lnkDeleteChannel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteChannel();
        }

        /// <summary>
        /// Deletes the channel.
        /// </summary>
        private void DeleteChannel()
        {
            GatewayConfig gatewayConfig = lvwChannels.SelectedObject as GatewayConfig;
            if (gatewayConfig != null) 
            {
                DialogResult result = FormHelper.Confirm(string.Format(Resources.MsgConfirmDeleteGateway, gatewayConfig.Id));
                if (result == DialogResult.Yes) 
                {
                    // Delete the gateway configuration
                    GatewayConfig.Delete(g=> g.Id == gatewayConfig.Id);

                    /*
                    this.lvwChannels.RemoveObject(gatewayConfig);
                    this.lvwChannels.RefreshObjects(this.lvwChannels.SelectedObjects);
                    */

                    //this.lvwChannels.ClearObjects();
                    //ShowChannels();

                    this.lvwChannels.RemoveObjects(this.lvwChannels.SelectedObjects);

                    if (GatewayRemoved != null)
                    {
                        // Raise the event
                        GatewayEventHandlerArgs arg = new GatewayEventHandlerArgs(gatewayConfig.Id);
                        this.GatewayRemoved.BeginInvoke(this, arg, new AsyncCallback(this.AsyncCallback), null);
                    }
                }
            } else 
            {
                FormHelper.ShowInfo(Resources.MsgGatewayMustBeSelected);
            }

        }
    }
}
