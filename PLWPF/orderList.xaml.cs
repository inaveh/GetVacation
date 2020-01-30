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
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for orderList.xaml
    /// </summary>
    public partial class orderList : Window
    {
        BL.IBl bl = FactoryBL.GetBL();
        public orderList()
        {
            InitializeComponent();
            reqList.ItemsSource = bl.getAllRequest();
        }

        private void Button_ClickX(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            orderList.Exit();
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
