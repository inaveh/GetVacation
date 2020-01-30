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
using BL;
using BE;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for deleteUnit.xaml
    /// </summary>
    public partial class deleteUnit : Window
    {
        BL.IBl bl = FactoryBL.GetBL();
        HostingUnit unit = new HostingUnit();

        public deleteUnit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bl.DeleteUnit(unit);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            hostingUnit.Exit();
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            hostingUnit sc = new hostingUnit();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

    }
}
