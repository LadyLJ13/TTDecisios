using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresseur_Singe
{
    public class Dresseur
    {
        public int Id { get; set; }
        public Singe Singe { get; set; }

        public Dresseur(int id, Singe singe)
        {
            Id = id;
            Singe = singe;
        }
        public void DonneOrdre()
        {
            Console.WriteLine($"Le dresseur n°{Id} dit à son singe {Singe.Name} d'exécuter ses tours");
            Thread.Sleep(1000);
        }
    }
}
