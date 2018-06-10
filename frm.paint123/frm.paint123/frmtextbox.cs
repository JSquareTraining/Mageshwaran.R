using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm.paint123
{
    public partial class frmtextbox : Form
    {
        public frmtextbox()
        {
            InitializeComponent();
        }
        string value1;
        string value2;
        string result;


        private void frmtextbox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnumber1_TextChanged(object sender, EventArgs e)
        {
            value1 = textnumber1.Text;
            result = value1 + value2;
            textnumber3.Text = result;

        }

        private void textnumber2_TextChanged(object sender, EventArgs e)
        {
            value2 = textnumber2.Text;
            result = value1 + value2;
            textnumber3.Text = result;
        }
    }
}
