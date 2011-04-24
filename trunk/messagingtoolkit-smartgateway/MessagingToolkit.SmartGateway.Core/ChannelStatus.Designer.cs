namespace MessagingToolkit.SmartGateway.Core
{
    partial class ChannelStatus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
            // Stop the message poller
            StopPoller();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvwChannelStatus = new MessagingToolkit.UI.ObjectListView();
            this.olvColChannelName = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColPort = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColOperator = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColSignalStrength = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColStatus = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.cmChannel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.lvwChannelStatus)).BeginInit();
            this.cmChannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwChannelStatus
            // 
            this.lvwChannelStatus.AllColumns.Add(this.olvColChannelName);
            this.lvwChannelStatus.AllColumns.Add(this.olvColPort);
            this.lvwChannelStatus.AllColumns.Add(this.olvColOperator);
            this.lvwChannelStatus.AllColumns.Add(this.olvColSignalStrength);
            this.lvwChannelStatus.AllColumns.Add(this.olvColStatus);
            this.lvwChannelStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColChannelName,
            this.olvColPort,
            this.olvColOperator,
            this.olvColSignalStrength,
            this.olvColStatus});
            this.lvwChannelStatus.ContextMenuStrip = this.cmChannel;
            this.lvwChannelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwChannelStatus.FullRowSelect = true;
            this.lvwChannelStatus.GridLines = true;
            this.lvwChannelStatus.Location = new System.Drawing.Point(0, 0);
            this.lvwChannelStatus.MultiSelect = false;
            this.lvwChannelStatus.Name = "lvwChannelStatus";
            this.lvwChannelStatus.ShowGroups = false;
            this.lvwChannelStatus.Size = new System.Drawing.Size(675, 582);
            this.lvwChannelStatus.TabIndex = 0;
            this.lvwChannelStatus.UseCompatibleStateImageBehavior = false;
            this.lvwChannelStatus.View = System.Windows.Forms.View.Details;
            // 
            // olvColChannelName
            // 
            this.olvColChannelName.Text = "Channel Name";
            this.olvColChannelName.Width = 200;
            // 
            // olvColPort
            // 
            this.olvColPort.Text = "Port";
            // 
            // olvColOperator
            // 
            this.olvColOperator.Text = "Operator Information";
            this.olvColOperator.Width = 120;
            // 
            // olvColSignalStrength
            // 
            this.olvColSignalStrength.Text = "Signal Strength %";
            this.olvColSignalStrength.Width = 100;
            // 
            // olvColStatus
            // 
            this.olvColStatus.FillsFreeSpace = true;
            this.olvColStatus.Text = "Status";
            // 
            // cmChannel
            // 
            this.cmChannel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startChannelToolStripMenuItem,
            this.stopChannelToolStripMenuItem,
            this.restartChannelToolStripMenuItem});
            this.cmChannel.Name = "cmChannel";
            this.cmChannel.Size = new System.Drawing.Size(158, 92);
            // 
            // startChannelToolStripMenuItem
            // 
            this.startChannelToolStripMenuItem.Name = "startChannelToolStripMenuItem";
            this.startChannelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startChannelToolStripMenuItem.Text = "Start Channel";
            this.startChannelToolStripMenuItem.Click += new System.EventHandler(this.startChannelToolStripMenuItem_Click);
            // 
            // stopChannelToolStripMenuItem
            // 
            this.stopChannelToolStripMenuItem.Name = "stopChannelToolStripMenuItem";
            this.stopChannelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stopChannelToolStripMenuItem.Text = "Stop Channel";
            this.stopChannelToolStripMenuItem.Click += new System.EventHandler(this.stopChannelToolStripMenuItem_Click);
            // 
            // restartChannelToolStripMenuItem
            // 
            this.restartChannelToolStripMenuItem.Name = "restartChannelToolStripMenuItem";
            this.restartChannelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.restartChannelToolStripMenuItem.Text = "Restart Channel";
            this.restartChannelToolStripMenuItem.Click += new System.EventHandler(this.restartChannelToolStripMenuItem_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 560);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(675, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // ChannelStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lvwChannelStatus);
            this.Name = "ChannelStatus";
            this.Size = new System.Drawing.Size(675, 582);
            this.Load += new System.EventHandler(this.ChannelStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvwChannelStatus)).EndInit();
            this.cmChannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.ObjectListView lvwChannelStatus;
        private System.Windows.Forms.StatusStrip ssStatus;
        private UI.OLVColumn olvColChannelName;
        private UI.OLVColumn olvColPort;
        private UI.OLVColumn olvColOperator;
        private UI.OLVColumn olvColSignalStrength;
        private UI.OLVColumn olvColStatus;
        private System.Windows.Forms.ContextMenuStrip cmChannel;
        private System.Windows.Forms.ToolStripMenuItem startChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartChannelToolStripMenuItem;
    }
}
