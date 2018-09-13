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

namespace bindingmarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        data1 oo;
        public MainWindow()
        {
            InitializeComponent();
            if(oo == null)
             oo = new data1();
            this.DataContext = oo;
            
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //int result = oo.Add();
            //txttotal.Text = result.ToString();
            staticvariable os = new staticvariable();
            os.add(10);
            int value = staticvariable.count;
            staticvariable os1 = new staticvariable();
            int value1 = staticvariable.count;
            
        }

        private void btnsum_Click(object sender, RoutedEventArgs e)
        {
            int result = oo.sum();
            txttotal.Text = result.ToString();
        }
    }
}
