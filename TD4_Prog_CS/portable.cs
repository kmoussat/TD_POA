using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4
{
    class Portable:Telephone
    {
        private string nom;

        public Portable(string marque, string numero, string nom):base(marque,numero)
        {
            this.nom = nom;
        }

        public String Nom
        {
            get { return nom; }
        }

        public override string ToString()
        {
            return "\nmarque: " + Marque + "\n numero: " + Numero + "\n nom propriétaire: " + nom;
        }
    }
}
