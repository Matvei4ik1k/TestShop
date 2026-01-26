using Microsoft.Win32;
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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            CategoryCmb.ItemsSource = App.context.Category.ToList(); //загружаем список категорий
            CategoryCmb.DisplayMemberPath = "Name"; //отображаем у элемнтов нахвание
            CategoryCmb.SelectedValuePath = "Id"; // при выборе элемента копируем Id
            CategoryCmb.SelectedIndex = 0; // выбираем первыйы эелемент списка по умолчанию

            ReleaseDateDp.SelectedDate = DateTime.Now; // выбираем текущую дату по умолчанию

        }

        private void LoadFromPCBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                PhotoTb.Text = openFileDialog.FileName;
            }
        }

        private void AddFromPCBtn_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product()
            {
                Name = NameTb.Text,
                Price = Convert.ToDecimal(PriceTb.Text),
                IdCategory = (Int32)CategoryCmb.SelectedValue,
                Description = DescriptionTb.Text,
                ReleaseDate = ReleaseDateDp.SelectedDate.Value,
                IsAvailable = IsAvailableCb.IsChecked.Value,
                Photo = PhotoTb.Text,
            };
            App.context.Product.Add(newProduct);
            App.context.SaveChanges();

            MessageBox.Show("Товар успешно добавлен", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            DialogResult = true;
        }
    
    }
}
