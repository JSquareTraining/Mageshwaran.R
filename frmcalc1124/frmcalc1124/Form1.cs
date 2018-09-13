using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmcalc1124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int i = 0;int j = 0; int result = 0;
        private void btnsum_Click(object sender, EventArgs e)

        {
            if (txtnum1.Text == "" || txtnum2.Text == ""||lbloperator1.Text=="")
            {
                MessageBox.Show("please enter the value");
            }
            else { 
                i = Convert.ToInt16(txtnum1.Text);
                j = Convert.ToInt16(txtnum2.Text);
            }
            
            
            
            //if (lbloperator1.Text == "/")
            //{
            //     result = i / j;

            //}
            //else if (lbloperator1.Text == "*")
            //{
            //     result = i * j;

            //}
            //else if (lbloperator1.Text == "+")
            //{
            //     result = i + j;

            // }
            //else if (lbloperator1.Text == "-")
            //{
            //     result = i - j;
            //}
            //else
            //{
            //    lbloperator2.Text = btnsum.Text;
            //}
           
            switch (lbloperator1.Text)
            {
                case "/":
                    result = i / j;
                    break;
                case "*":
                    result = i * j;
                    break;
                case "-":
                    result = i - j;
                    break;
                case "+":
                    result = i + j;
                    break;
                   
                default:
                    
                    break;
            }

            txtnum3.Text = Convert.ToString(result);
            lbloperator2.Text = "=";
            
        }
        
        private void lbloperator2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtnum3.Text = "";
            lbloperator1.Text = "";
            lbloperator2.Text = "";
        }
        private void button1(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (lbloperator1.Text == "" || txtnum1.Text == "")
                txtnum1.Text = txtnum1.Text+ a.Text;
            else
            {
              txtnum2.Text = txtnum2.Text+ a.Text;
            }
        }

        private void button2(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lbloperator1.Text =lbloperator1.Text+ b.Text;
        }
    }
}