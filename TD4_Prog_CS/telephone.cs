using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4
{
    class Telephone
    {
        private string marque;
        private string numero;

        public Telephone(string marque, string numero)
        {
            this.marque = marque;
            this.numero = numero;
        }

        public String Marque
        {
            get { return marque; }
        }

        public String Numero
        {
            get { return numero; }
        }

        public override string ToString()
        {
            return "marque : " + marque + "\n numero : " + numero;
        }
    }
}
