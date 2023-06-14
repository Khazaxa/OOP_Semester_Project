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
        public List<Car> MyCars { get; set; }

        public AvailableCarsView()
        {
            InitializeComponent();


            using (CarRentContext _context = new CarRentContext())
            {
                MyCars = _context.Cars.Include(c => c.Brand).ToList();
            }


            CarsList.ItemsSource = MyCars;


        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Logika obsługi kliknięcia przycisku Add
            AddCarView addCarView = new AddCarView();
            addCarView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addCarView.ShowDialog();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Logika obsługi kliknięcia przycisku Edit
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Logika obsługi kliknięcia przycisku Delete
        }
    }
}