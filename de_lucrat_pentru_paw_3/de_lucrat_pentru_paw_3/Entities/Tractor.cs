using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_3.Entities
{
    public class Tractor : IComparable<Tractor>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public bool IsElectric { get; set; }

        public Tractor() { }

        public Tractor(int id, string brand, bool isElectric)
        {
            Id = id;
            Brand = brand;
            IsElectric = isElectric;
        }

        public int CompareTo(Tractor other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
