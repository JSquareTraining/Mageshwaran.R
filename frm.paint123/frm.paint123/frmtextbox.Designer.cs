namespace frm.paint123
{
    partial class frmtextbox
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
            this.textnumber1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textnumber2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textnumber3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textnumber1
            // 
            this.textnumber1.Location = new System.Drawing.Point(27, 27);
            this.textnumber1.Name = "textnumber1";
            this.textnumber1.Size = new System.Drawing.Size(125, 26);
            this.textnumber1.TabIndex = 0;
            this.textnumber1.TextChanged += new System.EventHandler(this.textnumber1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(267, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textnumber2
            // 
            this.textnumber2.Location = new System.Drawing.Point(27, 97);
            this.textnumber2.Name = "textnumber2";
            this.textnumber2.Size = new System.Drawing.Size(132, 26);
            this.textnumber2.TabIndex = 2;
            this.textnumber2.TextChanged += new System.EventHandler(this.textnumber2_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(504, 73);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(229, 26);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // textnumber3
            // 
            this.textnumber3.Location = new System.Drawing.Point(27, 154);
            this.textnumber3.Name = "textnumber3";
            this.textnumber3.Size = new System.Drawing.Size(132, 26);
            this.textnumber3.TabIndex = 4;
            this.textnumber3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmtextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textnumber3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textnumber2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textnumber1);
            this.Name = "frmtextbox";
            this.Text = "frmtextbox";
            this.Load += new System.EventHandler(this.frmtextbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnumber1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textnumber2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textnumber3;
    }
}