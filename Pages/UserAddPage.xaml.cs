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
    /// Interaction logic for UserAddPage.xaml
    /// </summary>
    public partial class UserAddPage : Page
    {
        Users users;
        public UserAddPage(Users users)
        {
            this.users = users;
            InitializeComponent();
            //            CbBreadType.ItemsSource = EfModel.Init().Tovars.ToList();
            DataContext = users;
        }
        

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "*Jpeg images|*.jpg|All files|*.*"
            };
            if (openFile.ShowDialog() == true)
            {
                users.UsersPicture = File.ReadAllBytes(openFile.FileName);
            }
        }

        private void btSaveUserClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errorBuilder = new StringBuilder();

            try
            {
                Convert.ToString(tbUserName.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В имени, введено не имя!");
            }
            try
            {
                Convert.ToString(tbUserLogin.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В логине, введен не логин!");
            }
            try
            {
                Convert.ToString(tbUserPass.Text);
            }
            catch (FormatException)
            {
                errorBuilder.AppendLine("В пароле, введен не пароль!");
            }

            if (tbUserName.Text.Length < 1)
                errorBuilder.AppendLine("Заполните имя пользователя");
            if (tbUserLogin.Text.Length < 1)
                errorBuilder.AppendLine("Заполните логин пользователя");
            if (tbUserPass.Text.Length < 1)
                errorBuilder.AppendLine("Заполните пароль пользователя");
            if (errorBuilder.Length > 0)
            {
                MessageBox.Show(errorBuilder.ToString());
                return;
            }

            if (users.UserId == 0)
                EfModel.Init().Users.Add(users);
            EfModel.Init().SaveChanges();
            NavigationService.Navigate(new UserPage());
        }

        private void btRandomPassGeneratorClick(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int p = rand.Next(7, 50);
            tbUserPass.Clear();
                string iPass = "";
                string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                Random rnd = new Random();
                for (int i = 0; i < p; i++)
                {
                    iPass = iPass + arr[rnd.Next(0, 57)];
                }
            tbUserPass.Text = iPass;
        }
    }
}
