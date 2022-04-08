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
            LvTovars.ItemsSource = EfModel.Init().Tovars.Where(u => u.TovarName.Contains(tbSearchTovar.Text)).ToList();
        }
        public PageOne()
        {
            InitializeComponent();
        }
    }
}
