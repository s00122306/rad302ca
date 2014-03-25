using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using CA1S00122306.Models;

namespace CA1S00122306.DAL
{
    public class TravelContext:DbContext
    {
       public DbSet<Guest> Guests { get; set; } 
       public DbSet<Leg> Legs { get; set; }
       public DbSet<Trip> Trips { get; set; }  
 
    }
}