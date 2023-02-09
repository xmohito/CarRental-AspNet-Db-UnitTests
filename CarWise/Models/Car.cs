using System;
using System.Collections.Generic;

#nullable disable

namespace CarWise.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int IdBodyType { get; set; }
        public short Year { get; set; }
        public int IdFuel { get; set; }
        public double EngineCapacity { get; set; }
        public short Power { get; set; }
        public decimal PriceForDay { get; set; }

        public virtual BodyType IdBodyTypeNavigation { get; set; }
        public virtual Fuel IdFuelNavigation { get; set; }
    }
}
