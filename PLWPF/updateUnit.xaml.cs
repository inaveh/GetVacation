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
    /// Interaction logic for updateUnit.xaml
    /// </summary>
    public partial class updateUnit : Window
    {
        public updateUnit()
        {
            InitializeComponent();
        }


        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            hostingUnit sc = new hostingUnit();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            hostingUnit.Exit();
        }
    }


}
