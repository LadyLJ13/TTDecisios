using Dresseur_Singe;

Spectacle sp = new Spectacle();
Singe singe1 = new Singe("Louie", new List<Tour> { Tour.Piano, Tour.Equilibre, Tour.Flûte});
Singe singe2 = new Singe("Koko", new List<Tour> { Tour.Danse, Tour.Salto, Tour.Jonglage });
Dresseur dresseur1 = new Dresseur(1, singe1);
Dresseur dresseur2 = new Dresseur(2, singe2);
Spectateur spectateur1 = new Spectateur { };

sp.DebutSpectacle(dresseur1, singe1, spectateur1);
Console.WriteLine();
Console.WriteLine("=========== Spectacle suivant ==========");
Console.WriteLine();
sp.DebutSpectacle(dresseur2, singe2, spectateur1);