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
    /// Interaction logic for TovarLevelPageWinter.xaml
    /// </summary>
    public partial class TovarLevelPageWinter : Page
    {
        public TovarLevelPageWinter()
        {
            InitializeComponent();
            DgvTovarLvlWinter.ItemsSource = EfModel.Init().TovarLevelWinters.ToList();

        }

        private void btLvlWinterRaznClick(object sender, RoutedEventArgs e)
        {
            new WinterRaznForm().ShowDialog();
        }
    }
}
