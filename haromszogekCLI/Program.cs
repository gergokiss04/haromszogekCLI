using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace haromszogekCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //7.Feladat:Lista létrehozása adatok tárolásához
            List<Haromszog> haromszogek = new List<Haromszog>();
            List<Haromszog> derekszoguharomszogek = new List<Haromszog>();
            //5.Feladat:Fájl beolvasása
            StreamReader sr = new StreamReader("haromszogek.csv");

            Console.WriteLine("Derékszögű háromszögek:(Igaz/Hamis)");
            while (!sr.EndOfStream)
            {
                //6.Feladat:Példányosítás
                Haromszog h = new Haromszog(sr.ReadLine());

                haromszogek.Add(h);
                //9.Feladat:Függvény meghívásával derékszögű háromszög vizsgálása
                Console.WriteLine(derekszogu(h));

                if (derekszogu(h) == true)
                {
                    derekszoguharomszogek.Add(h);
                }

            }
            sr.Close();

            Console.WriteLine("");
            //10.Feladat:Derékszögű háromszög részletes kiírása
            Console.WriteLine("Derékszögű háromszögek adatai:");
            foreach (var item in derekszoguharomszogek)
            {
                Console.WriteLine($"a:{item.a} b:{item.b} c:{item.c}");


            }

            //11.Feladat:Legnagyobb területű háromszög megtalálása

            int legnagyobbterulet = 0;
            Haromszog legnagyobbTeruletu3szog = haromszogek[0];


            foreach (var item in haromszogek)
            {

                if (item.a * item.a + item.b * item.b == item.c * item.c)
                {
                    if (item.a * item.b / 2 > legnagyobbterulet)
                    {
                        legnagyobbterulet = item.a * item.b / 2;
                        legnagyobbTeruletu3szog = item;
                    }
                }


            }
            Console.WriteLine("");
            Console.WriteLine("A legnagyobb területű háromszög:" + legnagyobbterulet);
            Console.WriteLine("");
            Console.WriteLine("A legnagyobb területű háromszög adatai: a:" + legnagyobbTeruletu3szog.a + " b:" + legnagyobbTeruletu3szog.b + " c:" + legnagyobbTeruletu3szog.c);


            Console.ReadKey();
        }

        //8.Feladat:Függvény megírása
        public static bool derekszogu(Haromszog h)
        {
            if (h.a * h.a + h.b * h.b == h.c * h.c)
            {
                return true;
            }

            return false;

        }
    }
}
