using RentCar.Views;
using System.Windows;

namespace RentCar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            AddCarView addCarView = new AddCarView();
            addCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addCarView.ShowDialog();
        }

        private void RentCar_Click(object sender, RoutedEventArgs e)
        {
            RentCarView rentCarView = new RentCarView();
            rentCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            rentCarView.ShowDialog();
        }

        private void ReturnCar_Click(object sender, RoutedEventArgs e)
        {
            ReturnCarView returnCarView = new ReturnCarView();
            returnCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            returnCarView.ShowDialog();
        }

        private void AvailableCars_Click(object sender, RoutedEventArgs e)
        {
            AvailableCarsView availableCarsView = new AvailableCarsView();
            availableCarsView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            availableCarsView.ShowDialog();
        }

    }
}
