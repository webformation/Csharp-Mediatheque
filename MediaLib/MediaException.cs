using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    public class AdresseException  :  Exception
    {
        public AdresseException(string message) : base(message) { }
    }
    public class AbonneException : Exception
    {
        public AbonneException(string message) : base(message) { }
    }
}
