using System.Collections.Generic;
using CA1S00122306.Models;

namespace CA1S00122306.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CA1S00122306.DAL.TravelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CA1S00122306.DAL.TravelContext";
        }

        protected override void Seed(CA1S00122306.DAL.TravelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.People.AddOrUpdate(
              //  p => p.FullName,
                //new Person {FullName = "Andrew Peters"},
                //new Person {FullName = "Brice Lambson"},
                //new Person {FullName = "Rowan Miller"}
                //);

            Trip trip1 = new Trip
            {
                TripName = "Tour of Cavan",StartDate = DateTime.Parse("2014-05-01"),EndDate = DateTime.Parse("2014-20-01")
            };
            var legs = new List<Leg>
            {
                new Leg
                {
                    StartLocation = "Drung",
                    EndLocation = "Bunnoe",
                    StartDate = DateTime.Parse("2014-05-01"),
                    EndDate = DateTime.Parse("2014-09-01")
                },
                new Leg
                {
                    StartLocation = "Cornafean",
                    EndLocation = "Killeshandra",
                    StartDate = DateTime.Parse("2014-10-01"),
                    EndDate = DateTime.Parse("2014-15-04")
                },
                new Leg
                {
                    StartLocation = "Bawnboy",
                    EndLocation = "Blacklion",
                    StartDate = DateTime.Parse("2014-16-01"),
                    EndDate = DateTime.Parse("2014-2--04")
                }
            };
            context.Trips.Add(trip1);
            legs.ForEach(l=> context.Legs.Add(l));
            context.SaveChanges();
        }
    }
}
