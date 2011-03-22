namespace MessagingToolkit.SmartGateway.Core
{
    partial class Manual
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
            this.controlHeader1.Logo = global::MessagingToolkit.SmartGateway.Core.Properties.Resources.manual;
            this.controlHeader1.Name = "controlHeader1";
            this.controlHeader1.Size = new System.Drawing.Size(664, 90);
            this.controlHeader1.SubTitle = "Manual";
            this.controlHeader1.TabIndex = 4;
            this.controlHeader1.Title = "MessagingToolkit SmartGateway";
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlHeader1);
            this.Name = "Manual";
            this.Size = new System.Drawing.Size(664, 578);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlHeader controlHeader1;
    }
}
