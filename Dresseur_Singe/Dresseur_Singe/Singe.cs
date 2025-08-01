using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresseur_Singe
{
    public class Singe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tour> Tours { get; set; }

        public Singe(string name, List<Tour> tours)
        {
            Name = name;
            Tours = tours;
        }
    }
}
