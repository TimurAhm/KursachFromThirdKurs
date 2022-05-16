using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfExampleTimur343.DataBase;

namespace WpfExampleTimur343.Pages
{
    /// <summary>
    /// Interaction logic for TovarAddPage.xaml
    /// </summary>
    public partial class TovarAddPage : Page
    {
        Tovars tovars;
        public TovarAddPage(Tovars tovars)
        {
            this.tovars = tovars;
            InitializeComponent();
//            CbBreadType.ItemsSource = EfModel.Init().Tovars.ToList();
            DataContext = tovars;
        }

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "*Jpeg images|*.jpg|All files|*.*"
            };
            if (openFile.ShowDialog() == true)
            {
                tovars.TovarPicture = File.ReadAllBytes(openFile.FileName);
            }
        }

        private void btSaveTovarClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errorBuilder = new StringBuilder();

            try
            {
                Convert.ToString(tbTovarName.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В названии товара, введено не название!");
            }
            try
            {
                Convert.ToInt32(tbTovarCount.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В количестве товара, введено не количество!");
            }
            try
            {
                Convert.ToDateTime(tbTovarCreateDate.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В дате произведения товара, введена не дата!");
            }
            try
            {
                Convert.ToDateTime(tbTovarExpDate.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В дате истечения срока годности товара, введена не дата!");
            }
            try
            {
                Convert.ToDecimal(tbTovarPrice.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В цене товара, введена не цена!");
            }

            if (tbTovarName.Text.Length < 1)
                errorBuilder.AppendLine("Заполните название товара");
            if (tbTovarCount.Text.Length < 1)
                errorBuilder.AppendLine("Заполните количство товара");
            if (tbTovarCreateDate.Text.Length < 1)
                errorBuilder.AppendLine("Заполните дату производства товара");
            if (tbTovarExpDate.Text.Length < 1)
                errorBuilder.AppendLine("Заполните дату истечения срока годности товара");
            if (errorBuilder.Length > 0)
            {
                MessageBox.Show(errorBuilder.ToString());
                return;
            }

            if (tovars.TovarId == 0)
                EfModel.Init().Tovars.Add(tovars);
            EfModel.Init().SaveChanges();
            NavigationService.Navigate(new PageOne());
        }

        private void btDeleteClick(object sender, RoutedEventArgs e)
        {
         
            
        }
    }
}
