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
            if (tovars.TovarId == 0)
                EfModel.Init().Tovars.Add(tovars);
            EfModel.Init().SaveChanges();
        }

        private void btDeleteClick(object sender, RoutedEventArgs e)
        {
            EfModel.Init().Tovars.Remove(tovars);
            EfModel.Init().SaveChanges();
        }
    }
}
