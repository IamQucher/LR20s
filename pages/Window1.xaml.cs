using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
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
using System.Windows.Shapes;

namespace WpfApp1.pages
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private masterEntities bd = new masterEntities();

        public Window1()
        {
            InitializeComponent();
        }

        

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string maxArticleNumber = bd.Product.Max(p => p.ProductArticleNumber);
            int newArticleNumber = int.Parse(maxArticleNumber) + 1;

            Product newProduct = new Product
            {
                ProductArticleNumber = newArticleNumber.ToString(),
                ProductName = nameTextBox.Text,
                ProductDescription = descriptionTextBox.Text,
                ProductCategory = categoryComboBox.Text,
                ProductManufacturer = manufacturerTextBox.Text,
                ProductCost = decimal.Parse(costTextBox.Text),
                ProductDiscountAmount = string.IsNullOrEmpty(discountAmountTextBox.Text) ? null : (byte?)byte.Parse(discountAmountTextBox.Text),
                ProductQuantityInStock = int.Parse(quantityInStockTextBox.Text),
                ProductStatus = StatusTextBox.Text
            };

            bd.Product.Add(newProduct);
            bd.SaveChanges();

            Close();

        }
    }
}
