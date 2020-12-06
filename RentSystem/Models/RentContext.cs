using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RentSystem.Models
{
    public class RentContext: DbContext
    {
        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<User> Users { get; set; }
    }
}