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

namespace marklist
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt16(txt11.Text);
            int value2 = Convert.ToInt16(txt12.Text);
            int value3 = Convert.ToInt16(txt13.Text);
            int value4 = Convert.ToInt16(txt14.Text);
            int value5 = Convert.ToInt16(txt15.Text);
            if (value1 > 40)
            {
                txt11.Background = Brushes.Green;
            }
            else
            {
                txt11.Background = Brushes.Red;
            }
            if (value2 > 40)
            {
                txt12.Background = Brushes.Green;
                
            }
            else
            {
                txt12.Background = Brushes.Red;
            }
            if (value3 > 40)
            {
                txt13.Background = Brushes.Green;
            }
            else
            {
                txt13.Background = Brushes.Red;
            }
            if (value4> 40)
            {
                txt14.Background = Brushes.Green;
            }
            else
            {
                txt14.Background = Brushes.Red;
            }
            if (value5 > 40)
            {
                txt15.Background = Brushes.Green;
            }
            else
            {
                txt15.Background = Brushes.Red;
            }
            }
            
          
        }
    }

