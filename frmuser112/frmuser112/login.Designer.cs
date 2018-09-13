namespace frmuser112
{
    partial class login
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
            this.btnsum = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.chkbtn = new System.Windows.Forms.CheckBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.rdnbtn1 = new System.Windows.Forms.RadioButton();
            this.rdnbtn2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(236, 217);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(75, 34);
            this.btnsum.TabIndex = 0;
            this.btnsum.Text = "Submit";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(395, 217);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 34);
            this.btnclr.TabIndex = 1;
            this.btnclr.Text = "clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // chkbtn
            // 
            this.chkbtn.AutoSize = true;
            this.chkbtn.Location = new System.Drawing.Point(236, 151);
            this.chkbtn.Name = "chkbtn";
            this.chkbtn.Size = new System.Drawing.Size(85, 24);
            this.chkbtn.TabIndex = 2;
            this.chkbtn.Text = "I agree";
            this.chkbtn.UseVisualStyleBackColor = true;
            this.chkbtn.CheckedChanged += new System.EventHandler(this.chkbtn_CheckedChanged);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(236, 76);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(198, 26);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.UseSystemPasswordChar = true;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(236, 21);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(198, 26);
            this.txtnum1.TabIndex = 4;
            // 
            // rdnbtn1
            // 
            this.rdnbtn1.AutoSize = true;
            this.rdnbtn1.Location = new System.Drawing.Point(346, 150);
            this.rdnbtn1.Name = "rdnbtn1";
            this.rdnbtn1.Size = new System.Drawing.Size(68, 24);
            this.rdnbtn1.TabIndex = 5;
            this.rdnbtn1.TabStop = true;
            this.rdnbtn1.Text = "Male";
            this.rdnbtn1.UseVisualStyleBackColor = true;
            this.rdnbtn1.CheckedChanged += new System.EventHandler(this.radbtn_CheckedChanged);
            // 
            // rdnbtn2
            // 
            this.rdnbtn2.AutoSize = true;
            this.rdnbtn2.Location = new System.Drawing.Point(420, 151);
            this.rdnbtn2.Name = "rdnbtn2";
            this.rdnbtn2.Size = new System.Drawing.Size(87, 24);
            this.rdnbtn2.TabIndex = 6;
            this.rdnbtn2.TabStop = true;
            this.rdnbtn2.Text = "Female";
            this.rdnbtn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(110, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdnbtn2);
            this.Controls.Add(this.rdnbtn1);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.chkbtn);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnsum);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.CheckBox chkbtn;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.RadioButton rdnbtn1;
        private System.Windows.Forms.RadioButton rdnbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}