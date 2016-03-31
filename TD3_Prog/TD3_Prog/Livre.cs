using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Livre : Document
    {
        private string auteur;
        private int nb_pages;

        public Livre(int numero, string titre, string auteur, int nb_pages):base(numero,titre)
        {
            this.auteur = auteur;
            this.nb_pages = nb_pages;
        }


        public string Auteur
        {
            get { return auteur; }
        }

        public int Nb_pages
        {
            get { return nb_pages; }
            set { nb_pages = value; }
        }


        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
