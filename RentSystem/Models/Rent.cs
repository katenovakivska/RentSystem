using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentSystem.Models
{
    public partial class Rent
    {
        [Key]
        public int Rent_Id { get; set; }
        public int User_Id { get; set; }
        public int Building_Id { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Finish_Date { get; set; }
        public double Price { get; set; }
    }
}