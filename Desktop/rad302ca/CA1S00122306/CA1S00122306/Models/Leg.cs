using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CA1S00122306.Models
{
    public class Leg
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TripId { get; set; }

        public virtual Trip Trip { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }

        public bool checkLegOK()
        {
            if (this.StartDate > this.EndDate)
                return false;
            if (this.Trip.StartDate > this.StartDate || this.Trip.EndDate < this.EndDate)
                return false;

            List<Leg> otherLegs = new List<Leg>();
            otherLegs = this.Trip.Legs.OrderBy(l => l.StartDate).ToList();
            return true;

            foreach (var leg in otherLegs)
            {
                if (leg.StartDate <= this.StartDate && leg.EndDate >= leg.StartDate)
                    return false;
                if (leg.StartDate <= this.EndDate && leg.EndDate >= this.EndDate)
                    return false;
            }
            return true;
        }
    }
}