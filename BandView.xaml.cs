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


namespace ResponsiveLayout.UserControl
{
    /// <summary>
    /// Interaction logic for BandView.xaml
    /// </summary>
    public partial class BandView : System.Windows.Controls.UserControl
    {
        public BandView()
        {
            InitializeComponent();
            var products = GetProducts();
            if (products.Count > 0)
                ListViewProducts.ItemsSource = products;
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
        {
        new Product("band 1", 205.46, "/Assets/1.jpg"),
        //new Product("band 2", 205.46, "/Assets/1.jpg"),
        //new Product("band 3", 205.46, "/Assets/1.jpg"),
        //new Product("band 4", 205.46, "/Assets/1.jpg"),
        //new Product("band 5", 205.46, "/Assets/1.jpg"),
        //new Product("band 6", 205.46, "/Assets/1.jpg"),
        //new Product("band 7", 205.46, "/Assets/1.jpg"),
        //new Product("band 8", 205.46, "/Assets/1.jpg"),
        //new Product("band 9", 205.46, "/Assets/1.jpg"),
        //new Product("band 10", 205.46, "/Assets/1.jpg"),
        //new Product("band 11", 205.46, "/Assets/1.jpg"),
        //new Product("band 12", 205.46, "/Assets/1.jpg"),
        //new Product("band 13", 205.46, "/Assets/1.jpg"),
        //new Product("band 14", 205.46, "/Assets/1.jpg"),
        //new Product("band 15", 205.46, "/Assets/1.jpg"),
        //new Product("band 16", 205.46, "/Assets/1.jpg"),
        //new Product("band 17", 205.46, "/Assets/1.jpg"),
        //new Product("band 18", 205.46, "/Assets/1.jpg"),
        //new Product("band 19", 205.46, "/Assets/1.jpg"),
        //new Product("band 20", 205.46, "/Assets/1.jpg"),
        //new Product("band 21", 205.46, "/Assets/1.jpg"),
        //new Product("band 22", 205.46, "/Assets/1.jpg"),
        //new Product("band 23", 205.46, "/Assets/1.jpg"),
        //new Product("band 24", 205.46, "/Assets/1.jpg"),
        //new Product("band 25", 205.46, "/Assets/1.jpg"),
        //new Product("band 26", 205.46, "/Assets/1.jpg"),
        //new Product("band 27", 205.46, "/Assets/1.jpg"),
        //new Product("band 28", 205.46, "/Assets/1.jpg"),
        //new Product("band 29", 205.46, "/Assets/1.jpg"),
        //new Product("band 30", 205.46, "/Assets/1.jpg"),
        //new Product("band 31", 205.46, "/Assets/1.jpg"),
        //new Product("band 32", 205.46, "/Assets/1.jpg"),
        //new Product("band 33", 205.46, "/Assets/1.jpg"),
        //new Product("band 34", 205.46, "/Assets/1.jpg"),
        //new Product("band 35", 205.46, "/Assets/1.jpg"),
        //new Product("band 36", 205.46, "/Assets/1.jpg"),
        //new Product("band 37", 205.46, "/Assets/1.jpg"),
        //new Product("band 38", 205.46, "/Assets/1.jpg"),
        //new Product("band 39", 205.46, "/Assets/1.jpg"),
        //new Product("band 40", 205.46, "/Assets/1.jpg"),

      };
        }
    }
}