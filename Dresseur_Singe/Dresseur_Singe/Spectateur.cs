using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresseur_Singe
{
    public class Spectateur
    {
        public static bool Acro(Tour acrobatie)
        {
            return acrobatie == Tour.Equilibre || acrobatie == Tour.Danse || acrobatie == Tour.Jonglage || acrobatie == Tour.Salto;
        }

        public static bool Musique(Tour musique)
        {
            return musique == Tour.Flûte || musique == Tour.Piano;
        }
        public void Reagit(Tour tour, Singe singe)
        {
            if(Musique(tour))
            {
                Console.WriteLine($"Le spectateur siffle lorsque {singe.Name} joue de l'instrument {tour}");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine($"Le spectateur applaudit pendant le tour {tour} de {singe.Name}");
                Thread.Sleep(2000);
            }
        }
    }
}
