using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmletter
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

        private void btntemplates_Click(object sender, EventArgs e)
        {
            StringBuilder osb = new StringBuilder();
            osb.AppendFormat("Dear sir,I have honor to inform you that i am joining the company from today as  {0}.in respect to your oppintment letter dated  {1}" +
                "salary package in  {2}/.", txtfilename.Text, txtdtname.Text, txtslryname.Text);
            txtcontent.Text = osb.ToString();
        


            TextWriter otw;
            otw = File.CreateText(@"H:\frmletter\" + txtname.Text + ".doc");
            otw.Flush();
            otw.Close();
            if (chkbtn.Checked == false)
            {
                MessageBox.Show("please select agree");
            }
            else if (chkbtn.Checked == true)
            {
                MessageBox.Show("success");
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {

        }
        private void btnwrite_Click_1(object sender, EventArgs e)
        {
            TextWriter otw;
            otw = File.CreateText(@"H:\frmletter\" + txtname.Text+ ".txt");
            otw.WriteLine(txtcontent.Text);
            otw.Flush();
            otw.Close();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            TextReader otr;
            otr = File.OpenText(@"H:\frmletter\" + txtname.Text + ".txt");
            txtcontent.Text = otr.ReadToEnd();
            otr.Close();

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtcontent.Text =txtname.Text=txtdtname.Text=txtfilename.Text=txtslryname.Text= string.Empty;
        }
    }
}
 