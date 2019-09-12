using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Abonne
    {
        static private int _compteur = 0;
        static public int Compteur {
            get { return _compteur; }
            set { if (value > _compteur) _compteur = value; }
        }
        private int numero;
        public Civilite civilite;
        private string _nom;
        public string nom
        {
            get { return _nom; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    _nom = value;
                }
                else
                {
                    throw new AbonneException("nom incorrect");
                }
            }
        }
        public string prenom { get; set; }
        public int age { get; set; }
        private Adresse _adresse;
        public Adresse adresse
        {
            get { return _adresse; }
            set
            {
                if (value != null) { _adresse = value; }
                else
                {
                    throw new AbonneException("adresse non définie");
                }
            }
        }

        public Abonne(string c, string nom, string prenom, int age, Adresse adresse)
        {
            switch (c)
            {
                case "Mme":
                    civilite = Civilite.Madame;
                    break;
                case "M":
                    civilite = Civilite.Monsieur;
                    break;
                default:
                    throw new AbonneException("Civilité inconne");
                    break;
            }
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
            this.numero=Compteur++;
        }
        //static  Abonne()
        //{
        //    Console.WriteLine("Constructeur statique !");
        //}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(civilite.ToString());
            sb.Append(" ");
            sb.Append(prenom);
            sb.Append(" ");
            sb.Append(_nom);
            sb.Append(", age ");
            sb.Append(age);
            sb.Append(" ans, ");
            sb.Append(adresse);
            sb.Append(", identifiant : ");
            sb.Append(numero);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            var abonne = obj as Abonne;
            return abonne != null &&
                   nom == abonne.nom &&
                   prenom == abonne.prenom &&
                   age == abonne.age &&
                   adresse == abonne.adresse;
        }

        public override int GetHashCode()
        {
            var hashCode = 210653919;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prenom);
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Adresse>.Default.GetHashCode(adresse);
            return hashCode;
        }
    }

    enum Civilite { Madame, Monsieur}
}
