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
        public List<Car> MyCars { get; set; }

        public DeleteCarView()
        {
            InitializeComponent();

            using (CarRentContext _context = new CarRentContext())
            {
                MyCars = _context.Cars.Include(c => c.Brand).ToList();
            }


            CarsList.ItemsSource = MyCars;
        }

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
