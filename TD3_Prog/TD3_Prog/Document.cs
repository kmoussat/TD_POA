using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Document
    {
        private int numero;
        private string titre;

        public Document(int numero, string titre)
        {
            this.numero = numero;
            this.titre = titre;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Titre
        {
            get { return titre; }
        }

        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
