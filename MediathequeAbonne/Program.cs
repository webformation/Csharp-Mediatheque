using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Program
    {
        const int posRue = 4;
        const int posCP = 5;
        const int posVille = 6;
        static void Main(string[] args)
        {
            Adresse a = new Adresse("10 rue de la gare", "38000", "Grenoble");
            Console.WriteLine(a);
            Abonne ab1 = new Abonne("M", "Snow", "John", 30, a);
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
            Abonne.Compteur = 10;
            Console.WriteLine("Saisissez un abonne (civilite;nom;prenom;age;rue;cp;ville). Q pour quitter");
            while (true)
            {
                saisie = Console.ReadLine();
                if (saisie.ToLower() == "q") break;
                char[] separ = { ';' };
                string[] elems = saisie.Split(separ);
                try
                {
                    Adresse adresse = new Adresse(elems[posRue], elems[posCP], elems[posVille]);

                    int age;
                    if (!int.TryParse(elems[3], out age)) continue;
                    Abonne abonne = new Abonne(elems[0], elems[1], elems[2], age, adresse);
                    lecteurs.Ajout(abonne);
                }
                catch (AbonneException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (AdresseException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problème imprévu : " + e.Message);
                    break;
                }
            }
            afficheLecteurs();
        }
        enum position { ville = 4, rue = 3 }

    }
}

