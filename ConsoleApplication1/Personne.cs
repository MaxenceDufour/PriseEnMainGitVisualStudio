using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Personne
    {
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne()
        {
            Prenom = "New";
            Age = 0;
        }
        public Personne(string prenom, int age)
        {
            Prenom = prenom;
            Age = age;
        }

        public override string ToString()
        {
            return $"Mon prénom est {Prenom} et mon age est de {Age}.";
        }
    }
}
