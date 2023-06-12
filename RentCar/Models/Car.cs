using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Car
{
    public int Id { get; set; }

    public int BrandId { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public string RegistrationNumber { get; set; } = null!;

    public  Brand Brand { get; set; } = null!;

    //public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
