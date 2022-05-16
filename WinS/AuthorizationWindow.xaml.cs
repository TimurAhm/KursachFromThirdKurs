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
using System.Windows.Shapes;
using WpfExampleTimur343.DataBase;
using WpfExampleTimur343.Pages;

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    { 

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void btLoginClick(object sender, RoutedEventArgs e)
        {
            MapPage map = new MapPage();
            Mouse.OverrideCursor = Cursors.Wait;
         //   if (map.tbskld.Text == Convert.ToString(0))
            
                if (EfModel.Init().Users.Any(u => u.UserLogin == tbLogin.Text && u.UserPass == tbPass.Text))
                {
                    if (AuthClass.Auth(tbLogin.Text, tbPass.Text))
                    {
                        MainWindow mainWindow = new MainWindow();
                        Mouse.OverrideCursor = null;
                        MessageBox.Show("Добро пожаловать " + AuthClass.users.UserName + "!");
                        Hide();
                        mainWindow.ShowDialog();
                        Close();
                    }
                }
            
          //  if (map.tbskld.Text == Convert.ToString(1))
            
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
