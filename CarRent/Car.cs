using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace CarRent
{
    public class Car
    {  
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ReleaseYear { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public string Engine { get; set; }
    }
}
