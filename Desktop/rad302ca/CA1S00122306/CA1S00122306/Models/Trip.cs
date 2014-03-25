using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA1S00122306.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Viable { get; set; }
        public bool Complete { get; set; }

        public virtual ICollection<Leg> Legs { get; set; }

        /*public bool CheckTripComplete()
        {
            if (!this.Complete)
            {
                List<Leg> legs = new List<Leg>();

                if (legs.Count != 0)
                {
                    if (this.StartDate == legs[0].StartDate && this.EndDate == legs[0].EndDate)
                    {
                        if (legs.Count == 1)
                        {
                            return true;
                        }
                        
                    }
                }
            }
        }*/
    }

    
}