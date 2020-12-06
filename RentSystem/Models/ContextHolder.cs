using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentSystem.Models
{
    public static class ContextHolder
    {
        public static RentContext Context = new RentContext();

    }
}