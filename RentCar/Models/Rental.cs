﻿using System;
using System.Collections.Generic;

namespace RentCar.Models;

public partial class Rental
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int CustomerId { get; set; }

    public string RentalDate { get; set; }

    public string ReturnDate { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
