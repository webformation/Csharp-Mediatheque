using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    class Abonnes
    {
        private List<Abonne> _liste;
        public List<Abonne> liste
        {
            get { return _liste; }
        }
        public Abonnes()
        {
            _liste = new List<Abonne>();
        }
        public void Ajout(Abonne a)
        {
            liste.Add(a);
        }

    }
}
