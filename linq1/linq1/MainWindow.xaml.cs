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
using System.Collections;

namespace linq1
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
       
        public class productlist
        {
            public string productname;
            public string productprice;
            public string productqty;
            public string productimage;
        }
        List<productlist> productlistnames;
        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            if(productlistnames==null)
            productlistnames = new List<productlist>();

            productlistnames.Add(new productlist { productname = txtpname.Text, productprice = txtprname.Text, productqty = txtqty.Text, productimage = txtimage.Text });
            
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.IsEnabled = true;
          
            
            
                if (txtsearch.Text == "")
                {

                    
                }
                else
                {
                    var value = from prod in productlistnames
                                where prod.productname.Contains(txtsearch.Text) || prod.productprice.Contains(txtsearch.Text) || prod.productqty.Contains(txtsearch.Text) || prod.productimage.Contains(txtsearch.Text)
                                select prod;
                    foreach (var item in value)
                    {
                        txtpname.Text = item.productname;
                        txtprname.Text = item.productprice;
                        txtqty.Text = item.productqty;
                        
                    }
                }
               
                            
        }

        private void txtsearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtpname.Text = txtprname.Text = txtqty.Text = "";
        }
    }
}
