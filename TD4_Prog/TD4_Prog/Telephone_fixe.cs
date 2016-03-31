using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4_Prog
{
    class Telephone_fixe : Telephone
    {

        private string bureau;

        public Telephone_fixe(string marque, string numero, string bureau) : base(marque,numero)
        {
            this.bureau = bureau;
        }

        public string Bureau
        {
            get
            {
                return bureau;
            }

            set
            {
                bureau = value;
            }
        }

        public override string ToString()
        {

            return "Telephone fixe : \n" + Marque + "" + Numero + "" + Bureau;
        }
    }
}
