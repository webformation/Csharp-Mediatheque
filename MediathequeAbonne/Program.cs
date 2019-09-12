using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Program
    {
        static void Main(string[] args)
        {
            Adresse a = new Adresse("10 rue de la gare", "3800", "Grenoble");
            Console.WriteLine(a.Affiche());
            Abonne ab1 = new Abonne("Snow", "John", 30, a);
            Console.WriteLine(ab1.Affiche());
            Abonnes lecteurs = new Abonnes();
            lecteurs.Ajout(ab1);
            foreach (var x in lecteurs.liste)
            {
                Console.WriteLine(x.Affiche());
            }
        }
    }
}
