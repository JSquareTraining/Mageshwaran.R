using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Register;

namespace Register
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnread_Click(object sender, RoutedEventArgs e)
        {

            {
                if (txtUN.Text == "")
                {
                    MessageBox.Show("please enter the user name");
                }
                TextReader otr = File.OpenText(@"H:\register document\" + txtUN.Text + ".txt");
                string content = otr.ReadToEnd();
                


                string[] splitcontent = content.Split('|');
                txtUN.Text = splitcontent[0].ToString();
                txtFN.Text = splitcontent[1].ToString();
                txtLN.Text = splitcontent[2].ToString();
                txtPW.Text = splitcontent[3].ToString();
                txtC.Text = splitcontent[4].ToString();
                txtS.Text = splitcontent[5].ToString();
                txtctry.Text = splitcontent[6].ToString();
            }
        }
        

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            if (txtFN.Text == "")
            {
                MessageBox.Show("please enter your name");
            }
            else if (txtLN.Text == "")
            {
                MessageBox.Show("please enter your last name");
            }
            else if (txtUN.Text == "")
            {
                MessageBox.Show("please enter your user name");
            }
            else if (txtPW.Text == "")
            {
                MessageBox.Show("please enter your password");
            }
            else if (txtC.Text == "")
            {
                MessageBox.Show("please enter your city");
            }
            else if (txtS.Text == "")
            {
                MessageBox.Show("please enter your state");
            }
            else if (txtctry.Text == "")
            {
                MessageBox.Show("please enter your country");
            }
            //else if (chk10.Checked== false||chk12.Checked==false||chkBE.Checked==false||chkanydegree.Checked==false)
            //{
            //    MessageBox.Show("please select degeree")
            //}
           
            {
                    TextWriter otw;
                    otw = File.CreateText(@"H:\register document\" + txtUN.Text + ".txt");
                otw.WriteLine(txtUN.Text+"|"+ txtFN.Text + "|" + txtLN.Text + "|"  + txtPW.Text + "|"  + txtC.Text + "|" + txtS.Text + "|" + txtctry.Text+"|"+degreename.Text+"|");
                otw.Flush();
                otw.Close();
            }
            


        }

        private void txtUN_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (File.Exists(@"H:\register document\" + txtUN.Text + ".txt"))
            {
                MessageBox.Show("file already exist !!!");
            }


        }

        private void Grdnbtnm_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grdnbtnm_Checked_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grdnbtnm_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void chkanydegree_Checked(object sender, RoutedEventArgs e)
        {
            //if (chkanydegree.Checked == true)
            //{
            //    degreename.Text = degreename.Text;
            //}
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtUN.Text = "";
            txtFN.Text = "";
            txtLN.Text = "";
            txtPW.Text = "";
            txtS.Text = "";
            txtC.Text = "";
            txtctry.Text = "";
            degreename.Text = "";
            
        }
    }
}
