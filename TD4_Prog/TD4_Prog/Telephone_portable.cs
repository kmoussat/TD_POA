using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4_Prog
{
    class Telephone_portable : Telephone
    //class Telephone_portable : Telephone
    { 

        private string nom_proprio;

        public Telephone_portable(string marque, string numero, string nom_proprio) : base(marque, numero)
        {
            this.nom_proprio = nom_proprio;
        }

        public string Nom_proprio
        {
            get
            {
                return nom_proprio;
            }

            set
            {
                nom_proprio = value;
            }
        }

        public override string ToString()
        {
            return "Telephone portable : \n" + Marque + "" + Numero + "" + Nom_proprio;
        }

       
    }
}
