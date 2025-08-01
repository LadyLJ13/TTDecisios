using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresseur_Singe
{
    public class Spectacle
    {
        public Dresseur Dresseur { get; set; }
        public Singe Singe { get; set; }
        public Spectateur Spectateur { get; set; }

        public void DebutSpectacle(Dresseur dresseur, Singe singe, Spectateur spectateur)
        {
            dresseur.DonneOrdre();
            foreach (Tour tour in singe.Tours)
            {
                Console.WriteLine($"{singe.Name} exécute le tour {tour}");
                spectateur.Reagit(tour, singe);
            }
            
        }

    }
}
