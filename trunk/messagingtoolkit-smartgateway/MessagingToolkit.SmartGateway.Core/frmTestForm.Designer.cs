namespace MessagingToolkit.SmartGateway.Core
{
    partial class frmTestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.channelStatus1 = new MessagingToolkit.SmartGateway.Core.ChannelStatus();
            this.SuspendLayout();
            // 
            // channelStatus1
            // 
            this.channelStatus1.Location = new System.Drawing.Point(12, 3);
            this.channelStatus1.Name = "channelStatus1";
            this.channelStatus1.Size = new System.Drawing.Size(799, 625);
            this.channelStatus1.TabIndex = 0;
            // 
            // frmTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 673);
            this.Controls.Add(this.channelStatus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Container Form";
            this.Load += new System.EventHandler(this.frmNewMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ChannelStatus channelStatus1;
























    }
}