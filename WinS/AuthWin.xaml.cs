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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfExampleTimur343.DataBase;
using WpfExampleTimur343.Pages;

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for AuthWin.xaml
    /// </summary>
    public partial class AuthWin : Window
    {
        public AuthWin()
        {
            InitializeComponent();

            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = btLogin.ActualHeight;
            buttonAnimation.To = 300;
            buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            buttonAnimation.RepeatBehavior = new RepeatBehavior(1);
            btLogin.BeginAnimation(Button.WidthProperty, buttonAnimation);

            DoubleAnimation buttonPassAnimation = new DoubleAnimation();
            buttonPassAnimation.From = btClose.ActualHeight;
            buttonPassAnimation.To = 200;
            buttonPassAnimation.Duration = TimeSpan.FromSeconds(3);
            buttonPassAnimation.RepeatBehavior = new RepeatBehavior(1);
            btClose.BeginAnimation(Button.WidthProperty, buttonPassAnimation);
            //тут немного запутался, тут не кнопка пароля, а кнопка закрытия окна(close)
        }

        private void btLoginClick(object sender, RoutedEventArgs e)
        {
            MapPage map = new MapPage();
            Mouse.OverrideCursor = Cursors.Wait;
            //   if (map.tbskld.Text == Convert.ToString(0))
            
            
                if (EfModel.Init().Users.Any(u => u.UserLogin == tbLogin.Text && u.UserPass == tbPass.Password))
                {
                    if (AuthClass.Auth(tbLogin.Text, tbPass.Password))
                    {
                        MainBugulmaWindow mainBugulmaWindow = new MainBugulmaWindow();
                        //  MainWindow mainWindow = new MainWindow();
                        Mouse.OverrideCursor = null;
                        MessageBox.Show("Добро пожаловать " + AuthClass.users.UserName + "!");
                        Hide();
                        mainBugulmaWindow.ShowDialog();
                        Close();
                    }
                }
            
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
