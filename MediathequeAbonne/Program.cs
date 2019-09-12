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
            Console.WriteLine(a);
            Abonne ab1 = new Abonne("Snow", "John", 30, a);
            Console.WriteLine(ab1);
            Abonnes lecteurs = new Abonnes();
            lecteurs.Ajout(ab1);
            void afficheLecteurs()
            {
                Console.WriteLine("Liste des abonnés");
                foreach (var x in lecteurs.liste)
                {
                    Console.WriteLine(x);
                }
            }
            afficheLecteurs();
           

            string saisie;
            Console.WriteLine("Saisissez un abonne (nom;prenom;age;rue;cp;ville). Q pour quitter");
            while (true)
            {
                saisie = Console.ReadLine();
                if (saisie.ToLower() == "q") break;
                char[] separ = { ';' };
                string[] elems = saisie.Split(separ);
                Adresse adresse = new Adresse(elems[3], elems[4], elems[5]);
                int age;
                int.TryParse(elems[2], out age);
                Abonne abonne = new Abonne(elems[0], elems[1], age, adresse);
                lecteurs.Ajout(abonne);
            }
            afficheLecteurs();
        }
    }
}
