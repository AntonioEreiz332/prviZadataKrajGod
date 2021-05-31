using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            string sVelika; string sMala; string sPrvaTri; string sZadnjihPet; string s8_11;
            Console.WriteLine("Upišite niz znakova: ");
            unos = Console.ReadLine();
            sVelika = unos.ToUpper();
            sMala = unos.ToLower();
            sPrvaTri = unos.Substring(0, 3);
            sZadnjihPet=unos.Substring(unos.Length - Math.Min(5, unos.Length));
            s8_11 = unos.Substring(7, 3);

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);

            Console.ReadKey();

        }
    }
}
