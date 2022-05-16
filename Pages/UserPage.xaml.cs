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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private void UpdateData()
        {
            LvUsers.ItemsSource = EfModel.Init().Users.Where(t => t.UserName.Contains(tbSearchUser.Text)).ToList();
        }
        public UserPage()
        {
            InitializeComponent();
            LvUsers.ItemsSource = EfModel.Init().Users.ToList();
        }

        private void btEditUserClick(object sender, RoutedEventArgs e)
        {
            Users users = (sender as Button).DataContext as Users;
            NavigationService.Navigate(new UserAddPage(users));
        }

        private void btAddUserClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserAddPage(new Users()));
        }

        private void tbSearchUserChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
            if (tbSearchUser.Text == "")
            {
                tbSearchUser.Background = null;
                // Create an ImageBrush.
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =
                    new BitmapImage(
                        new Uri(@"C:\Users\student\Source\Repos\KurschTimurWPF\Resources\поиск.png", UriKind.Relative)
                    );
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.None;
                // Use the brush to paint the button's background.
                tbSearchUser.Background = textImageBrush;
            }
            else
            {
                tbSearchUser.Background = null;
                ImageBrush textimageBrush = new ImageBrush();
                textimageBrush.ImageSource = new BitmapImage(
                    new Uri(@"C:\Users\student\Source\Repos\KurschTimurWPF\Resources\поискПустой.png", UriKind.Relative));
                textimageBrush.AlignmentX = AlignmentX.Left;
                textimageBrush.Stretch = Stretch.None;
                tbSearchUser.Background = textimageBrush;
            }
        }

        private void btDeleteUserClick(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItems.Count > 0)
            {
                Users users = LvUsers.SelectedItems[0] as Users;
                if (MessageBox.Show("Вы удаляете этот товар :" + users.UserName + "?", "Удалить товар", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    EfModel.Init().Users.Remove(users);
                    EfModel.Init().SaveChanges();
                }
                UpdateData();
            }
        }
    }
}
