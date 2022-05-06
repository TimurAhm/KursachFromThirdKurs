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
using WpfExampleTimur343.DataBase;

namespace WpfExampleTimur343
{
    /// <summary>
    /// Interaction logic for WinterRaznForm.xaml
    /// </summary>
    public partial class WinterRaznForm : Window
    {
        public WinterRaznForm()
        {
            
            InitializeComponent();
            /* int razn = 0;
             string tovWinName = Convert.ToString(EfModel.Init().TovarLevelWinters.Select(t => t.TovarLevelWinterName));
             string tovName = Convert.ToString(EfModel.Init().Tovars.Select(t => t.TovarName));
             int tovWinCount = Convert.ToInt32(EfModel.Init().TovarLevelWinters.Select(t => t.TovarLevelWinterCount));
             int tovCount = Convert.ToInt32(EfModel.Init().Tovars.Select(t => t.TovarCount));
             if (tovName == tovWinName)
             {
                 razn = tovWinCount - tovCount;
                 DgvTovarLvlWinter.ItemsSource = Convert.ToString(razn);
             }*/
            //    DgvTovarLvlWinter.ItemsSource =
            // if (EfModel.Init().TovarLevelWinters.Where(t => t.TovarLevelWinterName == EfModel.Init().Tovars.Where(w => w.TovarName)))
            
            DgvTovarLvlWinter.ItemsSource = EfModel.Init().Tovars.ToList(); // EfModel.Init().Tovars.ToList();

        }
    }
}
