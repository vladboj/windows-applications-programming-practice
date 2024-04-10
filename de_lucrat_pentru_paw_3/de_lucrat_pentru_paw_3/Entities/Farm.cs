using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw_3.Entities
{
    public class Farm
    {
        public List<Tractor> Tractors { get; set; }

        public Farm()
        {
            Tractors = new List<Tractor>();
        }
    }
}
