using System;
using System.Collections.Generic;

#nullable disable

namespace CarWise.Models
{
    public partial class Rental
    {
        public int? IdCar { get; set; }
        public int IdCustomer { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Car IdCarNavigation { get; set; }
        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
