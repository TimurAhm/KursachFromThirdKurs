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
    /// Interaction logic for IngridientAddPage.xaml
    /// </summary>
    public partial class IngridientAddPage : Page
    {
        Ingridients ingridients;
        public IngridientAddPage(Ingridients ingridients)
        {
            this.ingridients = ingridients;
            InitializeComponent();
            DataContext = ingridients;
        }

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "*Jpeg images|*.jpg|All files|*.*"
            };
            if (openFile.ShowDialog() == true)
            {
                ingridients.IngridientPicture = File.ReadAllBytes(openFile.FileName);
            }
        }

        private void btSaveIngridientClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errorBuilder = new StringBuilder();

            if (tbIngName.Text.Length < 1)
                errorBuilder.AppendLine("Заполните название ингридиента");
            if (tbIngCount.Text.Length < 1)
                errorBuilder.AppendLine("Заполните количство ингридиентов");
            if (tbIngCreateDate.Text.Length < 1)
                errorBuilder.AppendLine("Заполните дату производства ингридиента");
            if (tbIngExpDate.Text.Length < 1)
                errorBuilder.AppendLine("Заполните дату истечения срока годности ингридиента");
            if (errorBuilder.Length > 0)
            {
                MessageBox.Show(errorBuilder.ToString());
                return;
            }


                if (ingridients.IngridientId == 0)
                    EfModel.Init().Ingridients.Add(ingridients);
                EfModel.Init().SaveChanges();
                NavigationService.Navigate(new IngridientPage());
            
        }

      //  private void btDeleteIngridientClick(object sender, RoutedEventArgs e)
      //  {
      //      EfModel.Init().Ingridients.Remove(ingridients);
      //      EfModel.Init().SaveChanges();
      //  }
    }
}
