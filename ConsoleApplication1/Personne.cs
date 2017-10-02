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
        public string Nom { get; set; }

        public Personne()
        {
            Prenom = "New";
            Nom = "new";
            Age = 0;
        }

        public Personne(string nom) : this()
        {
            Nom = nom;
        }


        public override string ToString()
        {
            return $"Mon prénom est {Prenom}, mon nom est {Nom} et mon age est de {Age}.";
        }
    }
}
