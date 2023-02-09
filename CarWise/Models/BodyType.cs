using System;
using System.Collections.Generic;

#nullable disable

namespace CarWise.Models
{
    public partial class BodyType
    {
        public BodyType()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
