using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Adresse
    {
        private string _cp;
        private string _ville;
        public string voie { get; set; }
        public string cp
        {
            get { return _cp; }
            set {
                if (value != null && value.Length == 5)
                {
                    _cp = value;
                }
                else
                {
                    throw new Exception("code postal incorrect");
                }
            }
        }
        public string ville {
            get { return _ville; }
            set
            {
                if (value != null && value.Length>=2)
                {
                    _ville = value;
                }
                else
                {
                    /**
                     *  a traiter
                     */
                }
            }
        }

        public Adresse(string voie, string cp, string ville)
        {
            this.voie = voie;
            this.cp = cp;
            this.ville = ville;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(voie);
            sb.Append(", ");
            sb.Append(cp);
            sb.Append(" ");
            sb.Append(ville);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            var adresse = obj as Adresse;
            return adresse != null &&
                   voie == adresse.voie &&
                   cp == adresse.cp &&
                   ville == adresse.ville;
        }

        public override int GetHashCode()
        {
            var hashCode = 758992713;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(voie);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cp);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ville);
            return hashCode;
        }

        public static bool operator ==(Adresse adresse1, Adresse adresse2)
        {
            return EqualityComparer<Adresse>.Default.Equals(adresse1, adresse2);
        }

        public static bool operator !=(Adresse adresse1, Adresse adresse2)
        {
            return !(adresse1 == adresse2);
        }

    }

}
