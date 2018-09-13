namespace frmletter
{
    partial class Form1
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
            this.txtdtname = new System.Windows.Forms.TextBox();
            this.txtslryname = new System.Windows.Forms.TextBox();
            this.txtcontent = new System.Windows.Forms.RichTextBox();
            this.btnread = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btntemplates = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbtn = new System.Windows.Forms.CheckBox();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdtname
            // 
            this.txtdtname.Location = new System.Drawing.Point(343, 31);
            this.txtdtname.Name = "txtdtname";
            this.txtdtname.Size = new System.Drawing.Size(136, 26);
            this.txtdtname.TabIndex = 3;
            // 
            // txtslryname
            // 
            this.txtslryname.Location = new System.Drawing.Point(508, 31);
            this.txtslryname.Name = "txtslryname";
            this.txtslryname.Size = new System.Drawing.Size(146, 26);
            this.txtslryname.TabIndex = 4;
            // 
            // txtcontent
            // 
            this.txtcontent.Enabled = false;
            this.txtcontent.Location = new System.Drawing.Point(21, 93);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(633, 210);
            this.txtcontent.TabIndex = 5;
            this.txtcontent.Text = "";
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(149, 358);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 37);
            this.btnread.TabIndex = 8;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(287, 360);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 37);
            this.btnclr.TabIndex = 9;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btntemplates
            // 
            this.btntemplates.Location = new System.Drawing.Point(468, 358);
            this.btntemplates.Name = "btntemplates";
            this.btntemplates.Size = new System.Drawing.Size(104, 37);
            this.btntemplates.TabIndex = 10;
            this.btntemplates.Text = "Tempaltes";
            this.btntemplates.UseVisualStyleBackColor = true;
            this.btntemplates.Click += new System.EventHandler(this.btntemplates_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(172, 31);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(118, 26);
            this.txtfilename.TabIndex = 2;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(21, 358);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 41);
            this.btnwrite.TabIndex = 7;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click_1);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(21, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 1;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(180, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 23);
            this.label.TabIndex = 13;
            this.label.Text = "Qualification";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(381, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(529, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salary";
            // 
            // chkbtn
            // 
            this.chkbtn.AutoSize = true;
            this.chkbtn.Location = new System.Drawing.Point(21, 309);
            this.chkbtn.Name = "chkbtn";
            this.chkbtn.Size = new System.Drawing.Size(102, 24);
            this.chkbtn.TabIndex = 6;
            this.chkbtn.Text = "I AGREE";
            this.chkbtn.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(23, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 23);
            this.Username.TabIndex = 16;
            this.Username.Text = "User name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.chkbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btntemplates);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.txtslryname);
            this.Controls.Add(this.txtdtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdtname;
        private System.Windows.Forms.TextBox txtslryname;
        private System.Windows.Forms.RichTextBox txtcontent;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btntemplates;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbtn;
        private System.Windows.Forms.Label Username;
    }
}

