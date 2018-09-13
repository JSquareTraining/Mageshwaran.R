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

namespace dbinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = oda;

        }


        Odata oda = new Odata { Uname = "magi", Umarks = 100 };

        private void btnclick_Click(object sender, RoutedEventArgs e)
        {
          
            
                MessageBox.Show(oda.Uname + "mark is" + oda.Umarks);
            
           
        }
    }
}
