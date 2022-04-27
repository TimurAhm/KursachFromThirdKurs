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
        
       // Tovars tovars1;
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
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                Tovars tovars = (sender as Button).DataContext as Tovars;
                NavigationService.Navigate(new TovarAddPage(tovars));
            }
            
        }

        private void btAddTovarClick(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                NavigationService.Navigate(new TovarAddPage(new Tovars()));
            }
        }

        private void tbSearchTovarChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
            if (tbSearchTovar.Text == "")
            {
                tbSearchTovar.Background = null;
                // Create an ImageBrush.
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =
                    new BitmapImage(
                        new Uri(@"C:\Users\User\source\repos\KurschTimurWPF2\Resources\поиск.png", UriKind.Relative)
                    );
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.None;
                // Use the brush to paint the button's background.
                tbSearchTovar.Background = textImageBrush;
            }
            else
            {
                tbSearchTovar.Background = null;
                ImageBrush textimageBrush = new ImageBrush();
                textimageBrush.ImageSource = new BitmapImage(
                    new Uri(@"C:\Users\User\source\repos\KurschTimurWPF2\Resources\поискПустой.png", UriKind.Relative));
                textimageBrush.AlignmentX = AlignmentX.Left;
                textimageBrush.Stretch = Stretch.None;
                tbSearchTovar.Background= textimageBrush;
            }
        }

        private void btTovarClick(object sender, RoutedEventArgs e)
        {
            Tovars tovars = (sender as Button).DataContext as Tovars;
            NavigationService.Navigate(new TovarDecriptionPage(tovars));
        }

        private void btDeleteTovarClick(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                if (LvTovars.SelectedItems.Count > 0)
                {
                    Tovars tovars = LvTovars.SelectedItems[0] as Tovars;
                    if (MessageBox.Show("Вы удаляете этот товар : " + tovars.TovarName + "?", "Удалить товар", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        EfModel.Init().Tovars.Remove(tovars);
                        EfModel.Init().SaveChanges();
                    }
                    UpdateData();
                }
            }
        }
    }
}
