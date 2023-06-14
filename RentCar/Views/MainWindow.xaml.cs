using RentCar.Views;
using System.Threading.Tasks;
using System.Windows;

namespace RentCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        /// <summary>
        /// Handles the click event of the AvailableCars button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private async void AvailableCars_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(50); // Minimalne opóźnienie

            AvailableCarsView availableCarsView = new AvailableCarsView();
            availableCarsView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            availableCarsView.Show();

            Close();
        }

        /// <summary>
        /// Handles the click event of the Customer button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private async void Customer_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(50); // Minimalne opóźnienie

            CustomersView customersView = new CustomersView();
            customersView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            customersView.Show();

            Close();
        }
    }
}
