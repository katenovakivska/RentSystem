using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentSystem.Models
{
    public partial class Appartment
    {
        [Key]
        public int Building_Id { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public int Number_Of_Rooms { get; set; }
        public double Monthly_Price { get; set; }
        public string Description { get; set; }
        public int Landlord_Id { get; set; }
        public string Status { get; set; }
    }
}