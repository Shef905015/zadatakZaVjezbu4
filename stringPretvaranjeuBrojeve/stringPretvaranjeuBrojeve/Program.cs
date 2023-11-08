using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPretvaranjeuBrojeve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;
            string x;
            string y;

            Console.WriteLine("Unesite jedan decimalni i jedan cijeli broj sa razmakom: ");
            recenica = Console.ReadLine();

            x = recenica.Substring(0, recenica.IndexOf(" "));
            y = recenica.Substring(recenica.LastIndexOf(" ") + 1);

            Console.WriteLine(x + " " + y);

            int x2 = Convert.ToInt32(x);
            double y2 = Convert.ToDouble(y);

            Console.WriteLine(x2 * 2);
            Console.WriteLine(y2 * 2);



            Console.ReadKey();

        }
    }
}
