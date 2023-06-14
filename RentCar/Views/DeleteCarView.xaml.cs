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
    /// Interaction logic for DeleteCarView.xaml
    /// </summary>
    public partial class DeleteCarView : Window
    {
        /// <summary>
        /// Gets or sets the list of cars to be displayed and selected for deletion.
        /// </summary>
        public List<Car> MyCars { get; set; }

        /// <summary>
        /// Initializes a new instance of the DeleteCarView class.
        /// </summary>
        public DeleteCarView()
        {
            InitializeComponent();

            using (CarRentContext _context = new CarRentContext())
            {
                MyCars = _context.Cars.Include(c => c.Brand).ToList();
            }

            CarsList.ItemsSource = MyCars;
        }

        /// <summary>
        /// Handles the click event of the DeleteButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            List<Car> carsToDelete = MyCars.Where(c => c.IsSelected).ToList();

            using (CarRentContext _context = new CarRentContext())
            {
                _context.Cars.RemoveRange(carsToDelete);
                _context.SaveChanges();
            }

            MyCars.RemoveAll(c => c.IsSelected);
            CarsList.Items.Refresh();
        }
    }
}
