using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Abonne
    {
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
                    throw new Exception("nom incorrect");
                }
            }
        }
        public string prenom { get; set; }
        public int age { get; set; }
        private Adresse _adresse;
        public Adresse adresse
        {
            get { return _adresse; }
            set { if (value != null) _adresse = value; }
        }

        public Abonne(string nom, string prenom, int age, Adresse adresse)
        {
           this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(prenom);
            sb.Append(" ");
            sb.Append(_nom);
            sb.Append(", age ");
            sb.Append(age);
            sb.Append(" ans, ");
            sb.Append(adresse);
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
}
