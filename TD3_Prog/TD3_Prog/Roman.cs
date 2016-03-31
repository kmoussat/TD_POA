using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Roman : Livre
    {
        private string prix;


        //public Livre(int numero, string titre, string auteur, int nb_pages):base(numero,titre)
        public Roman(int numero, string titre, string auteur, int nb_pages, string prix):base(numero,titre,auteur,nb_pages)
        {
            this.prix = prix;

        }


        public string Prix
        {
            get { return prix; }
        }


        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
