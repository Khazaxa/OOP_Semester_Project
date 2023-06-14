using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.AccessControl;
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
using RentCar.Models;

namespace RentCar.Views
{
    /// <summary>
    /// Interaction logic for AddCarView.xaml
    /// </summary>
    public partial class AddCarView : Window
    {
        /// <summary>
        /// Initializes a new instance of the AddCarView class.
        /// </summary>
        public AddCarView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the AddButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string ID = txtID.Text;
                string BrandName = txtBrand.Text;
                string Model = txtModel.Text;
                string Year = txtYear.Text;
                string RegistrationNumber = txtRegistrationNumber.Text;

                using (CarRentContext _context = new CarRentContext())
                {
                    int id;
                    if (!int.TryParse(ID, out id))
                    {
                        // Handle the case when the ID value is not a valid integer
                        MessageBox.Show("Invalid ID value. Please enter a valid integer.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    int year;
                    if (!int.TryParse(Year, out year))
                    {
                        // Handle the case when the Year value is not a valid integer
                        MessageBox.Show("Invalid Year value. Please enter a valid integer.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    Brand brand = _context.Brands.FirstOrDefault(b => b.Name == BrandName);
                    if (brand == null)
                    {
                        brand = new Brand { Name = BrandName };
                        _context.Brands.Add(brand);
                    }

                    Car car = new Car
                    {
                        Id = id,
                        Brand = brand,
                        Model = Model,
                        Year = year,
                        RegistrationNumber = RegistrationNumber
                    };

                    _context.Cars.Add(car);
                    _context.SaveChanges();

                    MessageBox.Show("Car added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the car record: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
