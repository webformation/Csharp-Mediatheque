﻿using System;
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
        }
    }
}