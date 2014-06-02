namespace GetLogs
{
    partial class Term
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Term));
            this.axMsRdpClient91 = new AxMSTSCLib.AxMsRdpClient9();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient91)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsRdpClient91
            // 
            this.axMsRdpClient91.Enabled = true;
            this.axMsRdpClient91.Location = new System.Drawing.Point(13, 13);
            this.axMsRdpClient91.Name = "axMsRdpClient91";
            this.axMsRdpClient91.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient91.OcxState")));
            this.axMsRdpClient91.Size = new System.Drawing.Size(594, 450);
            this.axMsRdpClient91.TabIndex = 0;
            this.axMsRdpClient91.OnConnecting += new System.EventHandler(this.axMsRdpClient91_OnConnecting);
            // 
            // Term
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 475);
            this.Controls.Add(this.axMsRdpClient91);
            this.Name = "Term";
            this.Text = "Term";
            this.Load += new System.EventHandler(this.Term_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient91)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient9 axMsRdpClient91;
    }
}