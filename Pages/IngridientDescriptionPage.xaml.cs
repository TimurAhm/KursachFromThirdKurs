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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfExampleTimur343.DataBase;

namespace WpfExampleTimur343.Pages
{
    /// <summary>
    /// Interaction logic for IngridientDescriptionPage.xaml
    /// </summary>
    public partial class IngridientDescriptionPage : Page
    {
        Ingridients ingridients;
        public IngridientDescriptionPage(Ingridients ingridients)
        {
            this.ingridients = ingridients;
            InitializeComponent();
            DataContext=ingridients;
        }
    }
}
