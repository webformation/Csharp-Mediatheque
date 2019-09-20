using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeAbonne
{
    public class Abonnes
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
            if (!liste.Contains(a))
            {
                liste.Add(a);
            }
        }
        public bool enregistre(string nomFichier)
        {
            StreamWriter swr = null;
            try
            {
                swr = File.CreateText(nomFichier);
                foreach (var x in liste)
                {
                    swr.WriteLine(x);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (swr != null) swr.Close();
            }
        }
    }
}
