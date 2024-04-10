using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_2.Entities
{
    public class Reservation : IComparable<Reservation>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReservationTime { get; set; }

        public Reservation() { }

        public Reservation(int id, string name, DateTime reservationTime)
        {
            Id = id;
            Name = name;
            ReservationTime = reservationTime;
        }

        public int CompareTo(Reservation other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
