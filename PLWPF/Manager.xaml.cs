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
using BE;
using BL;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Manager.Exit();
        }
        private static void Exit()
        {
            throw new NotImplementedException();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (pas.Password == "1346")
            {
                pageManager sc = new pageManager();
                this.Visibility = Visibility.Hidden;
                sc.Show();
            }
            else
            {
                MessageBox.Show("הקוד שגוי");
            }

        }
        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            MainWindow sc = new MainWindow();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

    }
}
