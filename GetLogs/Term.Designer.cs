namespace SysTools
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnShowOutput = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(594, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 39);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnShowOutput
            // 
            this.btnShowOutput.Location = new System.Drawing.Point(107, 38);
            this.btnShowOutput.Name = "btnShowOutput";
            this.btnShowOutput.Size = new System.Drawing.Size(75, 23);
            this.btnShowOutput.TabIndex = 3;
            this.btnShowOutput.Text = "Output";
            this.btnShowOutput.UseVisualStyleBackColor = true;
            this.btnShowOutput.Click += new System.EventHandler(this.btnShowOutput_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(200, 40);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Term
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 475);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShowOutput);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Term";
            this.Text = "Term";
            this.Load += new System.EventHandler(this.Term_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnShowOutput;
        private System.Windows.Forms.Button btnQuit;

    }
}