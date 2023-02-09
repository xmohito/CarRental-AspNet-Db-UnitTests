using System;
using System.Collections.Generic;

#nullable disable

namespace CarWise.Models
{
    public partial class Fuel
    {
        public Fuel()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string TypeOfFuel { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
