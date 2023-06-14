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
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : Window
    {
        /// <summary>
        /// Initializes a new instance of the CustomersView class.
        /// </summary>
        public CustomersView()
        {
            InitializeComponent();
            LoadData();
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

        /// <summary>
        /// Loads the customer data into the CustomersList.
        /// </summary>
        private void LoadData()
        {
            using (var context = new CarRentContext())
            {
                var query = context.Customers
                    .Include(c => c.Rentals)
                    .SelectMany(c => c.Rentals.DefaultIfEmpty(), (c, r) => new
                    {
                        Id = c.Id,
                        Name = $"{c.FirstName} {c.LastName}",
                        Email = c.Email,
                        PhoneNumber = c.Phone,
                        RentalDate = r != null ? r.RentalDate.ToString() : "",
                        ReturnDate = r != null ? r.ReturnDate.ToString() : ""
                    });

                var customerDataList = query
                    .OrderBy(c => c.Id)
                    .ToList();

                CustomersList.ItemsSource = customerDataList;
            }
        }

        /// <summary>
        /// Refreshes the customer data in the CustomersList.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Refresh(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
