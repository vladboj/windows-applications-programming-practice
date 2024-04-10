using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_2.Entities
{
    public class Restaurant
    {
        public List<Reservation> Reservations { get; set; }

        public Restaurant()
        {
            Reservations = new List<Reservation>();
        }
    }
}
