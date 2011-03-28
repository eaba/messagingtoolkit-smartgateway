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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwChannelStatus = new MessagingToolkit.UI.ObjectListView();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.olvColChannelName = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColPort = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColOperator = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColSignalStrength = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            this.olvColStatus = ((MessagingToolkit.UI.OLVColumn)(new MessagingToolkit.UI.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.lvwChannelStatus)).BeginInit();
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
            this.lvwChannelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwChannelStatus.FullRowSelect = true;
            this.lvwChannelStatus.GridLines = true;
            this.lvwChannelStatus.Location = new System.Drawing.Point(0, 0);
            this.lvwChannelStatus.Name = "lvwChannelStatus";
            this.lvwChannelStatus.ShowGroups = false;
            this.lvwChannelStatus.Size = new System.Drawing.Size(675, 582);
            this.lvwChannelStatus.TabIndex = 0;
            this.lvwChannelStatus.UseCompatibleStateImageBehavior = false;
            this.lvwChannelStatus.View = System.Windows.Forms.View.Details;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 560);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(675, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
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
            this.olvColOperator.Text = "Operator";
            this.olvColOperator.Width = 120;
            // 
            // olvColSignalStrength
            // 
            this.olvColSignalStrength.Text = "Signal Strength";
            this.olvColSignalStrength.Width = 100;
            // 
            // olvColStatus
            // 
            this.olvColStatus.FillsFreeSpace = true;
            this.olvColStatus.Text = "Status";
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
    }
}
