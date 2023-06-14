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
        public CustomersView()
        {
            InitializeComponent();
            LoadData();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void LoadData()
        {
            using (var context = new CarRentContext())
            {
                var query = context.Customers.Include(c => c.Rentals).SelectMany(c => c.Rentals.Select(r => new
                {
                    Id = c.Id,
                    Name = $"{c.FirstName} {c.LastName}",
                    Email = c.Email,
                    PhoneNumber = c.Phone,
                    RentalDate = r.RentalDate,
                    ReturnDate = r.ReturnDate
                }));

                var customerRentalDataList = query.OrderBy(c => c.Id).ToList();

                CustomersList.ItemsSource = customerRentalDataList;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh(object sender, RoutedEventArgs e)
        {

        }
    }
}
