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
    /// Interaction logic for IngridientPage.xaml
    /// </summary>
    public partial class IngridientPage : Page
    {
        private void UpdateData()
        {
            LvIngridients.ItemsSource = EfModel.Init().Ingridients.Where(t => t.IngridientName.Contains(tbSearchIngridient.Text)).ToList();
        }
        public IngridientPage()
        {
            InitializeComponent();
            LvIngridients.ItemsSource = EfModel.Init().Ingridients.ToList();
        }

        private void btEditIngridient(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                Ingridients ingridients = (sender as Button).DataContext as Ingridients;
                NavigationService.Navigate(new IngridientAddPage(ingridients));
            }
        }

        private void btAddIngridient(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                NavigationService.Navigate(new IngridientAddPage(new Ingridients()));
            }
        }

        private void tbSearchIngridientChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
            if (tbSearchIngridient.Text == "")
            {
                tbSearchIngridient.Background = null;
                // Create an ImageBrush.
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =
                    new BitmapImage(
                        new Uri(@"C:\Users\User\source\repos\KurschTimurWPF2\Resources\поиск.png", UriKind.Relative)
                    );
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.None;
                // Use the brush to paint the button's background.
                tbSearchIngridient.Background = textImageBrush;
            }
            else
            {
                tbSearchIngridient.Background = null;
                ImageBrush textimageBrush = new ImageBrush();
                textimageBrush.ImageSource = new BitmapImage(
                    new Uri(@"C:\Users\User\source\repos\KurschTimurWPF2\Resources\поискПустой.png", UriKind.Relative));
                textimageBrush.AlignmentX = AlignmentX.Left;
                textimageBrush.Stretch = Stretch.None;
                tbSearchIngridient.Background = textimageBrush;
            }
        }

        private void btDeleteIngridientClick(object sender, RoutedEventArgs e)
        {
            if (AuthClass.users.UserPriority == "user")
            {
                
                MessageBox.Show("У вас недостаточно прав");
            }
            else
            {
                if (LvIngridients.SelectedItems.Count > 0)
                {
                    Ingridients ingridients = LvIngridients.SelectedItems[0] as Ingridients;
                    if (MessageBox.Show("Вы удаляете этот ингридиент: " + ingridients.IngridientName + "?", "Удалить товар", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        EfModel.Init().Ingridients.Remove(ingridients);
                        EfModel.Init().SaveChanges();
                    }
                    UpdateData();

                }
            }
        }

        private void btIngridientClick(object sender, RoutedEventArgs e)
        {
            Ingridients ingridients = (sender as Button).DataContext as Ingridients;
            NavigationService.Navigate(new IngridientDescriptionPage(ingridients));
        }
    }
}
