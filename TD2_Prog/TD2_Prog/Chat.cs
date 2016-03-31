using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2_Prog
{
    class Chat
    {
        public String nom;
        public double poids;
        public Boolean DoitFaireUnRegime;
        public int Max = 9;
        public int Min = 3;
        public static Random A = new Random();


        public Chat(String nom, double poids)
        {
            this.nom = nom;
            double B = A.NextDouble() * (Max - Min) + Min;
            this.poids = B;

            if(poids <= (Max-Min))
            {
                this.DoitFaireUnRegime = false;
            }
            else
            {
                this.DoitFaireUnRegime = true;
            }

        }

        public String Nom
        {
            get { return nom; }
        }

        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        public override string ToString()
        {
            if(this.DoitFaireUnRegime == false)
            {
                return "Le chat " + this.nom + " pèse " + this.poids + "Kg et ne doit pas faire de regime.";

            }
            else
            {
                return "Le chat " + this.nom + " pèse " + this.poids + "Kg et doit faire un régime.";
            }
        }


        public double Croquettes(double poids)
        {
            double ratio = 20 * poids;

            if (this.DoitFaireUnRegime == true)
            {
                ratio = ratio - (ratio * 15 / 100);
                Console.WriteLine("Le chat" + this.nom + " doit suivre une ration journalière de " + ratio + "g");
                return 0;
            }
            else {

                Console.WriteLine("Le chat " + this.nom + " a une consommation journalière de " + ratio + "g");
                return 0;
            }
            
        }

        

    }
}
