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


namespace calculator
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

        private void btnsum_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt16(txtnum1.Text);
            int j = Convert.ToInt16(txtnum2.Text);
            int result = 0;
            {
                switch (lbloperator.Content)

                {
                    case "/":
                        result = i/ j;
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

            }

            txtresult.Text = Convert.ToString(result);
            lbloperator1.Content = "=";
           
        }

       

       
        private void btn11(object sender, RoutedEventArgs e)
        {
            Button a = (Button)sender;
            if ( lbloperator.Content ==""|| txtnum1.Text == "")
                txtnum1.Text = txtnum1.Text + a.Content;
            else
            {
                txtnum2.Text = txtnum2.Text+ a.Content;
            }
        }

        

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            lbloperator.Content = "";
            lbloperator1.Content = "";
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresult.Text = "";
        }

        

        private void txtnum1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtnum1.Text == "")
            {
                txtnum1.Background = Brushes.Red;
            }
            else
            {
                txtnum1.Background = Brushes.White;
            }
        }

        private void txtnum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnum2.Text == "")
            {
                txtnum2.Background = Brushes.Red;
            }
            else
            {
                txtnum2.Background = Brushes.White;
            }
        }

        private void txtresult_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtresult.Text == "")
            {
                txtresult.Background = Brushes.Green;
            }
           
        }

        private void btnaction(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
          lbloperator.Content = b.Content;
            
        }
    }
}
