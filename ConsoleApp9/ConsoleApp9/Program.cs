using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dat2 = new DateTime();
            Console.WriteLine(dat2);
            Console.WriteLine("La valeur de dat2  " + dat2.ToString(System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("La deuxième valeur de dat2  " + dat2.Equals(DateTime.MinValue));
            Console.ReadLine();

        }
    }
}
