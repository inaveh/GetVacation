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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using BL;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AddUnit.xaml
    /// </summary>
    public partial class AddUnit : Window
    {
        BL.IBl bl = FactoryBL.GetBL();
        HostingUnit newUnit = new HostingUnit();
       
        private string msg;

        public AddUnit()
        {
            InitializeComponent();
            SelectedArea.ItemsSource = Enum.GetValues(typeof(AREA));
            SelectedType.ItemsSource = Enum.GetValues(typeof(TYPE));
            unitDetails.DataContext = newUnit;
           
        }

        private void AddUnit_Click(object sender, RoutedEventArgs e)
        {
            if (HotelName.Text != "" && SelectedArea.SelectedItem !=null && SelectedType.SelectedItem !=null)
            {
                unitDetails.DataContext = newUnit;


                bl.AddUnit(newUnit);

                MainWindow sc = new MainWindow();
                this.Visibility = Visibility.Hidden;
                sc.Show();
            }
            else
                MessageBox.Show(msg, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);

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

        private void ComboBox_area(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_type(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
