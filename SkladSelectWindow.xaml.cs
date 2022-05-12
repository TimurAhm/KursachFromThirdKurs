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
using WpfExampleTimur343.Pages;

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for SkladSelectWindow.xaml
    /// </summary>
    public partial class SkladSelectWindow : Window
    {
        public SkladSelectWindow()
        {
            InitializeComponent();
            PageSwitcher.Navigate(new MapPage());
        }
    }
}
