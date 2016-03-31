using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Manuel : Livre
    {
        private int niveau;

       // public Roman(int numero, string titre, string auteur, int nb_pages, string prix):base(numero,titre,auteur,nb_pages)
        public Manuel(int numero, string titre, string auteur, int nb_pages, int niveau) : base(numero, titre, auteur, nb_pages)
        {
            this.niveau = niveau;

        }

        public Manuel(int numero, string titre, string auteur, int nb_pages) : base(numero, titre, auteur, nb_pages)
        {
          
        }


        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
