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
using BL;
using BE;


namespace PLWPF
{
    /// <summary>
    /// Interaction logic for OpenOrder.xaml
    /// </summary>
    public partial class OpenOrder : Window
    {
        BL.IBl bl = FactoryBL.GetBL();
        GuestRequest newReq = new GuestRequest();
        private string msg;

        
        public OpenOrder()
        {
            InitializeComponent();
            SelectedArea.ItemsSource = Enum.GetValues(typeof(AREA));
            SelectedType.ItemsSource = Enum.GetValues(typeof(TYPE));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            OpenOrder.Exit();
        }
        private static void Exit()
        {
            throw new NotImplementedException();
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            MainWindow sc = new MainWindow();
            this.Visibility = Visibility.Hidden;
            sc.Show();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (
                    FamilyName.Text != "" && PrivateName.Text != "" && EmailAdrress.Text != "" &&
                    SelectedArea.SelectedItem != null && SelectedType.SelectedItem != null &&
                    Children.Text != null && Adults.Text != null && ReleaseDate.SelectedDate != null &&
                    EntryDate.SelectedDate != null
                )
            {
                newReq.PrivateName =PrivateName.Text;
                newReq.FamilyName =FamilyName.Text;
                newReq.EntryDate = EntryDate.SelectedDate.Value.Date;
                newReq.ReleaseDate = ReleaseDate.SelectedDate.Value.Date;
                int areaIndex = (int)newReq.Area;  
                int typeIndex = (int)newReq.Type ;
                SelectedArea.SelectedIndex  = areaIndex;
                SelectedType.SelectedIndex = typeIndex;
                newReq.Pool = (bool)Pool.IsChecked;
                newReq.ChildrenAttractions = (bool)Attractions.IsChecked;

                bl.AddRequest(newReq);

                MainWindow sc = new MainWindow();
                this.Visibility = Visibility.Hidden;
                sc.Show();

            }
            else
                MessageBox.Show(msg, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_type(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_area(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
