using RentCar.Views;
using System.Threading.Tasks;
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

        private async void AvailableCars_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1); // Minimalne opóźnienie

            AvailableCarsView availableCarsView = new AvailableCarsView();
            availableCarsView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            availableCarsView.Show();

            Close();
        }
    }
}
