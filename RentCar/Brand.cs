﻿using System;
using System.Collections.Generic;

namespace RentCar;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
