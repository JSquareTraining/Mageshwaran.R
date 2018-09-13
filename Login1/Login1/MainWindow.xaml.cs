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
using System.Globalization;


namespace Login1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadresourcefiles("ua-UA");
        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            if (combolang.Text == "")
            {
                MessageBox.Show("please select language");
            }
            else if (combostate.Text == "")
            {
                MessageBox.Show("please select state");
            }
            else if (combocutry.Text == "")
            {
                MessageBox.Show("please select country");
            }
            else if (txtuser.Text == "")
            {
                MessageBox.Show("please enter your username");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("please enter your password");
            }
            else if (txtuser.Text == txtpass.Text)
            {
                {
                    var newpage = new LogIn();
                    newpage.txtlang1.Text = combolang.Text;
                    newpage.txtstate1.Text = combostate.Text;
                    newpage.txtcuntry1.Text = combocutry.Text;
                    newpage.txtusername1.Text = txtuser.Text;
                    newpage.txtpassword1.Text = txtpass.Text;

                    if (combolang.Text == "Tamil")
                    {
                        loadresourcefiles("ta-TA");

                    }
                    else if (combolang.Text == "Hindi")
                    {
                        loadresourcefiles("hi-Hi");

                    }
                    else if (combolang.Text == "Japanese")
                    {
                        loadresourcefiles("jp-JP");
                    }
                    else if (combolang.Text == "Kanatam")
                    {
                        loadresourcefiles("ka-KA");
                    }
                    else if (combolang.Text == "Malayalam")
                    {
                        loadresourcefiles("ma-MA");
                    }
                    else if (combolang.Text == "Telugu")
                    {
                        loadresourcefiles("te-TE");
                    }
                    newpage.Show();
                    this.Hide();
                }
            }
            else 
            {
                MessageBox.Show("Invalid your password");
            }
            
         
            
         
          






        }
        public void loadresourcefiles(string type)
        {
            var resources = new ResourceDictionary();
            Resources.Source = new Uri("pack://application:,,,/ResourceDictionary/Language." + type + ".xaml", UriKind.Absolute);
            var current = Application.Current.Resources.MergedDictionaries.FirstOrDefault(m => m.Source.OriginalString.EndsWith("string.xaml"));
            if (current != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(current);
            }
            Application.Current.Resources.MergedDictionaries.Add(Resources);
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            combolang.Text = combostate.Text = combocutry.Text = txtuser.Text = txtpass.Text = "";
        }
    }
}
