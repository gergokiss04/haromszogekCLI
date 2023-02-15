using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    //2.Feladat:
    //Osztály létrehozása
    public class Haromszog
    {
        public int a { get; private set; }
        public int b { get; private set; }
        public int c { get; private set; }

        //3.-4.Feladat:
        //Konstruktor létrehozása és oldalak értékeinek átadása
        public Haromszog(string sor)
        {
            string[] darabok = sor.Split(' ');

            this.a = Convert.ToInt32(darabok[0]);
            this.b = Convert.ToInt32(darabok[1]);
            this.c = Convert.ToInt32(darabok[2]);
        }
    }
}
