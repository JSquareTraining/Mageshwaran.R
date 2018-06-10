using System;
using System.Drawing;
using System.Windows.Forms;

namespace frm.paint123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        public Color selectcolor;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblmain.BackColor = selectcolor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tools_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            lblblack.Enabled = true;
            lblsi.Enabled = true;
            lblmaro.Enabled = true;
            lblre.Enabled = true;
            lbldyell.Enabled = true;
            lblyellow.Enabled = true;
            lbldgreen.Enabled = true;
            lblblue.Enabled = true;
            lblnavy.Enabled = true;
            lblwhite.Enabled = true;
            lblsilver.Enabled = true;
            lblbrow.Enabled = true;
            lblfuchsia.Enabled = true;
            lblgold.Enabled = true;
            lbllig.Enabled = true;
            lbllime.Enabled = true;
            lblaqua.Enabled = true;
            lbllas.Enabled = true;
            lbg.Enabled = true;

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblblack_Click(object sender, EventArgs e)
        {
            selectcolor = lblblack.BackColor;
            box.BackColor = lblblack.BackColor;
          
          
        }

        private void lblsi_Click(object sender, EventArgs e)
        {
            selectcolor = lblsi.BackColor;
            box.BackColor = lblsi.BackColor;
        }

        private void lblmaro_Click(object sender, EventArgs e)
        {
            selectcolor = lblmaro.BackColor;
            box.BackColor = lblmaro.BackColor;
        }

        private void lblre_Click(object sender, EventArgs e)
        {
            selectcolor = lblre.BackColor;
            box.BackColor = lblre.BackColor;
        }

        private void lbldyell_Click(object sender, EventArgs e)
        {
            selectcolor = lbldyell.BackColor;
            box.BackColor = lbldyell.BackColor;
        }

        private void lblyellow_Click(object sender, EventArgs e)
        {
            selectcolor = lblyellow.BackColor;
            box.BackColor = lblyellow.BackColor;
        }

        private void lbldgreen_Click(object sender, EventArgs e)
        {
            selectcolor = lbldgreen.BackColor;
            box.BackColor = lbldgreen.BackColor;
        }

        private void lblblue_Click(object sender, EventArgs e)
        {
            selectcolor = lblblue.BackColor;
            box.BackColor = lblblue.BackColor;
        }

        private void lblnavy_Click(object sender, EventArgs e)
        {
            selectcolor = lblnavy.BackColor;
           box.BackColor = lblnavy.BackColor;
        }

        private void lblwhite_Click(object sender, EventArgs e)
        {
            selectcolor = lblwhite.BackColor;
            box.BackColor = lblwhite.BackColor;
        }

        private void lblsilver_Click(object sender, EventArgs e)
        {
            selectcolor = lblsilver.BackColor;
            box.BackColor = lblsilver.BackColor;

        }

        private void lblbrow_Click(object sender, EventArgs e)
        {
            selectcolor = lblbrow.BackColor;
            box.BackColor = lblbrow.BackColor;
        }

        private void lblfuchsia_Click(object sender, EventArgs e)
        {
            selectcolor = lblfuchsia.BackColor;
            box.BackColor = lblfuchsia.BackColor;
        }

        private void lblgold_Click(object sender, EventArgs e)
        {
            selectcolor = lblgold.BackColor;
            box.BackColor = lblgold.BackColor;
        }

        private void lbllig_Click(object sender, EventArgs e)
        {
            selectcolor = lbllig.BackColor;
            box.BackColor = lbllig.BackColor;
        }

        private void lbllime_Click(object sender, EventArgs e)
        {
            selectcolor = lbllime.BackColor;
            box.BackColor = lbllime.BackColor;
        }

        private void lblaqua_Click(object sender, EventArgs e)
        {
            selectcolor = lblaqua.BackColor;
            box.BackColor = lblaqua.BackColor;
        }

        private void lbllas_Click(object sender, EventArgs e)
        {
            selectcolor = lbllas.BackColor;
            box.BackColor = lbllas.BackColor;
        }

        private void lbg_Click(object sender, EventArgs e)
        {
            selectcolor = lbg.BackColor;
            box.BackColor = lbg.BackColor;
        }
    }
    }

