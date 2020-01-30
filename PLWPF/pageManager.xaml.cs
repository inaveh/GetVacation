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
    /// Interaction logic for pageManager.xaml
    /// </summary>
    public partial class pageManager : Window
    {
        public pageManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            orderList sc = new orderList();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            unitList sc = new unitList();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            unitList sc = new unitList();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }
        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            MainWindow sc = new MainWindow();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            pageManager.Exit();

        }

        private static void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
