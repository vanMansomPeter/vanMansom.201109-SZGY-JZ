using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanMansom._201109_SZGY_JZ
{
    //érték típus struct
    struct EmberS
    {
        public string nev;
        public int kor;
    }
    //referencia típus class
    class EmberC
    {
        public string nev;
        public int kor;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new EmberS() { nev = "Zoli", kor = 30 };
            var c1 = new EmberC() { nev = "Zoli", kor = 30 };
            //Deklarál egy új vátozót, majd másol minden értéket- érték típus      
            var s2 = s1;
            // létrehoz egy ALIAST, ami ugyan arra a memória területre mutat-referencia típus
            var c2 = c1;
            //Az új megvátozik, az eredeti marad
            s2.nev = "Jolánka";
            //mivel ez csak egy referencia, ezért akár c1-et vagy c2-őt kérdezném le ugyan az lenne az eredmény
            c2.nev = "Jolánka";

            Console.WriteLine($"snev: {s1.nev}\nskor: {s1.kor}");

            Console.WriteLine($"cnev: {c1.nev}\nckor: {c1.kor}");

            Console.ReadKey();
        }
    }
}
