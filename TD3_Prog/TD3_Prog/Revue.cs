using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Revue : Document
    {
        private int mois;
        private int annee;


        //public Livre(int numero, string titre, string auteur, int nb_pages):base(numero,titre)
        public Revue(int numero, string titre,int mois, int annee):base(numero, titre)
        {
            this.mois = mois;
            this.annee= annee;
        }

        public int Mois
        {
            get { return mois; }
            set { mois = value; }
        }


        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }


        public override string ToString()
        {
            return "ToString est redéfini";
        }
    }
}
