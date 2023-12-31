﻿using System;
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

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void btWelcomeClick(object sender, RoutedEventArgs e)
        {
           // AuthorizationWindow authorizationWindow= new AuthorizationWindow();
            SkladSelectWindow skladSelectWindow = new SkladSelectWindow();
            Hide();
            skladSelectWindow.ShowDialog();
            Show();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            // App.Current.Shutdown();
            Close();
        }
    }
}
