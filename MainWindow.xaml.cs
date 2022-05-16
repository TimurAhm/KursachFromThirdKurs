using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using WpfExampleTimur343.Pages;

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstFormClick(object sender, RoutedEventArgs e)
        {
        }

        private void PageOneClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new PageOne());
        }

        private void IngridientsPageClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new IngridientPage());
        }

        private void TovarLevelClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new TovarLevelPage());
        }

        private void btTovarLvlPageSummerClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new TovarLevelPage());
        }

        private void btTovarLvlPageAutumnClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new TovarLevelPageAutumn());
        }

        private void btTovarLvlPageWinterClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new TovarLevelPageWinter());
        }

        private void btTovarLvlPageSpringClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new TovarLevelPageSpring());
        }

        private void btUsersClick(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
               // SystemSounds.Beep.Play();
               
            }
            else
            {
                PageSwitcher.Navigate(new UserPage());
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
            
        }

        private void MapClick(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Navigate(new MapPage());
        }
    }
}
