using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Dictionnaire : Document
    {
        private string langue;

        //public Livre(int numero, string titre, string auteur, int nb_pages):base(numero,titre)
        public Dictionnaire(int numero, string titre, string langue) : base(numero, titre)
        {
            this.langue = langue;
     
        }


        public string Langue
        {
            get { return langue; }
        }

     
        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
