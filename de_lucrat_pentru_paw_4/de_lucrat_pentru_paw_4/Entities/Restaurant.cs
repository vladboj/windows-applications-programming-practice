using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_4.Entities
{
    public class Restaurant
    {
        public List<Waiter> Waiters { get; set; }

        public Restaurant()
        {
            Waiters = new List<Waiter>();
        }
    }
}
