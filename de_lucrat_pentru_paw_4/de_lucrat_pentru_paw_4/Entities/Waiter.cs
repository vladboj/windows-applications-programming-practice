using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_4.Entities
{
    public class Waiter : IComparable<Waiter>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Waiter() { }

        public Waiter(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        public int CompareTo(Waiter other)
        {
            return BirthDate.CompareTo(other.BirthDate);
        }
    }
}
