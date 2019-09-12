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
                    /**
                     *  a traiter
                     */
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
    }
}
