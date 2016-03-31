using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4_Prog
{
    public class Telephone : IComparable<Telephone>
    {
        

        private string marque;
        private string numero;
      
      

        public Telephone(string marque, string numero)
        {
            this.marque = marque;
            this.numero = numero;
            
        }

        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

       

        public override string ToString()
        {
            return Marque + "" + Numero;
        }

        public int CompareTo(Telephone T)
        {
            Console.WriteLine(this.marque + "Compar avec " + T.marque);
            Console.WriteLine(this.marque.CompareTo(T.Marque));
            return this.marque.CompareTo(T.Marque);


        }

     


    }
}