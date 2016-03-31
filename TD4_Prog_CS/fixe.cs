using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4
{
    class Fixe:Telephone
    {
        private string bureau;

        public Fixe(string marque,string numero,string bureau):base(marque,numero)
        {
            this.bureau = bureau;
        }

        public String Bureau
        {
            get { return bureau; }
        }

        public override string ToString()
        {
            return "\nmarque: " + Marque + "\n numero: " + Numero + "\n bureau: " + bureau;
        }
    }
}
