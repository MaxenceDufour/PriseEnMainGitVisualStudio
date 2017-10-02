using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            Console.WriteLine(p1);
            Personne p2 = new Personne("Bienvenue");
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
