using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljaneZad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prviBroj, drugiBroj, treciBroj;

            Console.WriteLine("Unesi prvi broj: ");
            prviBroj = Console.ReadLine() ;
            Console.WriteLine("Unesi drugi broj: ");
            drugiBroj = Console.ReadLine();
            Console.WriteLine("Unesi treci broj: ");
            treciBroj = Console.ReadLine();

            int pBroj = Convert.ToInt32(prviBroj);
            int dBroj = Convert.ToInt32(drugiBroj);
            int tBroj = Convert.ToInt32(treciBroj);

            if (pBroj > dBroj && pBroj > tBroj) {
                Console.WriteLine(pBroj);
            }
            if (dBroj > pBroj && dBroj > tBroj)
            {
                Console.WriteLine(dBroj);
            }
            if (tBroj > pBroj && tBroj > dBroj)
            {
                Console.WriteLine("Najveći broj je " +tBroj);
            }


                Console.ReadKey();
        }
    }
}
