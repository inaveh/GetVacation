using BL;
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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for unitList.xaml
    /// </summary>
    public partial class unitList : Window
    {
        BL.IBl bl = FactoryBL.GetBL();
        public unitList()
        {
            InitializeComponent();
            UnitsList.ItemsSource = bl.getAllUnits();
        }

        private void Button_ClickX(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            unitList.Exit();
        }

        private static void Exit()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pageManager sc = new pageManager();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }
    }
}
