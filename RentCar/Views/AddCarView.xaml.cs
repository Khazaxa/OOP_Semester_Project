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
        public AddCarView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedID = txtID.Text;
                string selectedBrandName = txtBrand.Text;
                string selectedModel = txtModel.Text;
                string selectedYear = txtYear.Text;
                string selectedRegistrationNumber = txtRegistrationNumber.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the car record: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
