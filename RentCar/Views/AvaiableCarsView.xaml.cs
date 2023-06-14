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
using Microsoft.EntityFrameworkCore;
using RentCar.Models;

namespace RentCar.Views
{
    /// <summary>
    /// Interaction logic for AvailableCarsView.xaml
    /// </summary>
    public partial class AvailableCarsView : Window
    {
        /// <summary>
        /// Gets or sets the list of available cars.
        /// </summary>
        public List<Car> MyCars { get; set; }

        /// <summary>
        /// Initializes a new instance of the AvailableCarsView class.
        /// </summary>
        public AvailableCarsView()
        {
            InitializeComponent();

            using (CarRentContext _context = new CarRentContext())
            {
                MyCars = _context.Cars.Include(c => c.Brand).ToList();
            }

            CarsList.ItemsSource = MyCars;
        }

        /// <summary>
        /// Handles the click event of the AddButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for handling the Add button click
            AddCarView addCarView = new AddCarView();
            addCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addCarView.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the DeleteButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for handling the Delete button click
            DeleteCarView deleteCarView = new DeleteCarView();
            deleteCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            deleteCarView.ShowDialog();
        }

        /// <summary>
        /// Refreshes the list of available cars.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Refresh(object sender, RoutedEventArgs e)
        {
            using (CarRentContext _context = new CarRentContext())
            {
                MyCars = _context.Cars.Include(c => c.Brand).ToList();
            }

            CarsList.ItemsSource = MyCars;
        }

        /// <summary>
        /// Handles the click event of the Return button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
