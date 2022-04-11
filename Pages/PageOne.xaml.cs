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
using WpfExampleTimur343.DataBase;

namespace WpfExampleTimur343.Pages
{
    /// <summary>
    /// Interaction logic for PageOne.xaml
    /// </summary>
    public partial class PageOne : Page
    {
        private void UpdateData()
        {
            LvTovars.ItemsSource = EfModel.Init().Tovars.Where(t => t.TovarName.Contains(tbSearchTovar.Text)).ToList();
        }
        public PageOne()
        {
            InitializeComponent();
            LvTovars.ItemsSource = EfModel.Init().Tovars.ToList();
        }

        private void btEditClick(object sender, RoutedEventArgs e)
        {
            Tovars tovars = (sender as Button).DataContext as Tovars;
            NavigationService.Navigate(new TovarAddPage(tovars));
        }

        private void btAddTovarClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TovarAddPage(new Tovars()));
        }

        private void tbSearchTovarChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }
    }
}
