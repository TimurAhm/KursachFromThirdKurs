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
    /// Interaction logic for TovarDecriptionPage.xaml
    /// </summary>
    public partial class TovarDecriptionPage : Page
    {
        Tovars tovars1;
        public TovarDecriptionPage(Tovars tovars)
        {
            this.tovars1 = tovars;
            InitializeComponent();
            DataContext = tovars1;
        }
    }
}
