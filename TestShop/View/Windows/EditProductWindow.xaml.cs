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
using System.Windows.Shapes;
using TestShop.Model;

namespace TestShop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {
        Product selectedProduct;
        public EditProductWindow(Model.Product selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
            DataContext = selectedProduct;

            CategoryCmb.ItemsSource = App.context.Category.ToList();
            CategoryCmb.DisplayMemberPath = "Name";
            CategoryCmb.SelectedValuePath = "Id";
            CategoryCmb.SelectedIndex = 0;

        }

        private void LoadFromPCBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddFromPCBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
