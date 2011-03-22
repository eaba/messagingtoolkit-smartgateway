namespace MessagingToolkit.SmartGateway.Core
{
    partial class Documentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentation));
            this.controlHeader1 = new MessagingToolkit.SmartGateway.Core.ControlHeader();
            this.lineItem1 = new MessagingToolkit.SmartGateway.Core.LineItem();
            this.lineItem2 = new MessagingToolkit.SmartGateway.Core.LineItem();
            this.lineItem3 = new MessagingToolkit.SmartGateway.Core.LineItem();
            this.SuspendLayout();
            // 
            // controlHeader1
            // 
            this.controlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlHeader1.Location = new System.Drawing.Point(0, 0);
            this.controlHeader1.Logo = global::MessagingToolkit.SmartGateway.Core.Properties.Resources.information1;
            this.controlHeader1.Name = "controlHeader1";
            this.controlHeader1.Size = new System.Drawing.Size(475, 87);
            this.controlHeader1.SubTitle = "Documentation";
            this.controlHeader1.TabIndex = 3;
            this.controlHeader1.Title = "MessagingToolkit SmartGateway";
            // 
            // lineItem1
            // 
            this.lineItem1.LinkDescription = "Link description";
            this.lineItem1.LinkImage = ((System.Drawing.Bitmap)(resources.GetObject("lineItem1.LinkImage")));
            this.lineItem1.LinkName = "Link name";
            this.lineItem1.LinkToClass = "";
            this.lineItem1.LinkToModule = "";
            this.lineItem1.Location = new System.Drawing.Point(19, 119);
            this.lineItem1.Name = "lineItem1";
            this.lineItem1.Size = new System.Drawing.Size(509, 62);
            this.lineItem1.TabIndex = 4;
            // 
            // lineItem2
            // 
            this.lineItem2.LinkDescription = "Link description";
            this.lineItem2.LinkImage = ((System.Drawing.Bitmap)(resources.GetObject("lineItem2.LinkImage")));
            this.lineItem2.LinkName = "Link name";
            this.lineItem2.LinkToClass = "";
            this.lineItem2.LinkToModule = "";
            this.lineItem2.Location = new System.Drawing.Point(19, 200);
            this.lineItem2.Name = "lineItem2";
            this.lineItem2.Size = new System.Drawing.Size(509, 62);
            this.lineItem2.TabIndex = 5;
            // 
            // lineItem3
            // 
            this.lineItem3.LinkDescription = "Link description";
            this.lineItem3.LinkImage = ((System.Drawing.Bitmap)(resources.GetObject("lineItem3.LinkImage")));
            this.lineItem3.LinkName = "Link name";
            this.lineItem3.LinkToClass = "";
            this.lineItem3.LinkToModule = "";
            this.lineItem3.Location = new System.Drawing.Point(19, 281);
            this.lineItem3.Name = "lineItem3";
            this.lineItem3.Size = new System.Drawing.Size(509, 62);
            this.lineItem3.TabIndex = 6;
            // 
            // Documentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lineItem3);
            this.Controls.Add(this.lineItem2);
            this.Controls.Add(this.lineItem1);
            this.Controls.Add(this.controlHeader1);
            this.Name = "Documentation";
            this.Size = new System.Drawing.Size(475, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlHeader controlHeader1;
        private LineItem lineItem1;
        private LineItem lineItem2;
        private LineItem lineItem3;
    }
}
