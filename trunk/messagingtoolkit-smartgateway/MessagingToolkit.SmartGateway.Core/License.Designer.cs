namespace MessagingToolkit.SmartGateway.Core
{
    partial class License
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
            this.controlHeader1 = new MessagingToolkit.SmartGateway.Core.ControlHeader();
            this.SuspendLayout();
            // 
            // controlHeader1
            // 
            this.controlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlHeader1.Location = new System.Drawing.Point(0, 0);
            this.controlHeader1.Logo = global::MessagingToolkit.SmartGateway.Core.Properties.Resources.license;
            this.controlHeader1.Name = "controlHeader1";
            this.controlHeader1.Size = new System.Drawing.Size(471, 90);
            this.controlHeader1.SubTitle = "License";
            this.controlHeader1.TabIndex = 4;
            this.controlHeader1.Title = "MessagingToolkit SmartGateway";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlHeader1);
            this.Name = "License";
            this.Size = new System.Drawing.Size(471, 497);
            this.Load += new System.EventHandler(this.License_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlHeader controlHeader1;
    }
}
