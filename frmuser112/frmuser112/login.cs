using System;
using System.Windows.Forms;

namespace frmuser112
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
         
            if (txtnum1.Text == "")
            {
                MessageBox.Show("please enter your name");
            }
            else
            if (txtnum2.Text == "")

            {
                MessageBox.Show("please enter your password");
            }
            else
            {
                if (rdnbtn1.Checked)
                {
                    this.Text = rdnbtn1.Text;
                }
                else if (rdnbtn2.Checked)
                {
                    this.Text = rdnbtn2.Text;
                }
                else
                {
                    MessageBox.Show("please select male OR female");
                    
                }


                //if (txtnum1.Text == txtnum2.Text)
                // if (chkbtn.Checked==true)
                //    {
                //        this.Text = chkbtn.Text;
                //    }
                //    else
                //    {
                //        MessageBox.Show("please select I agree", "text", MessageBoxButtons.RetryCancel);
                //    }
                //else
                //{
                //    if (txtnum1.Text == txtnum2.Text) 
                //    MessageBox.Show("success");

                //}

                if (chkbtn.Checked == false)
                {
                    MessageBox.Show("please select I agree", "text", MessageBoxButtons.RetryCancel);
                }
                 if (txtnum1.Text == txtnum2.Text)
                {

                    MessageBox.Show("success");

                }
                else {
                    MessageBox.Show("failed");
                }


            }
            
        }
       
        



        private void chkbtn_CheckedChanged(object sender, EventArgs e)
        {
          
          
        }



        private void radbtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
             
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
