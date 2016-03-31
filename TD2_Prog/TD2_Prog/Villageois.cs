using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2_Prog
{
    class Villageois
    {
        public String nom;
        public double poids;
        public Boolean malade;
        public int Max = 150;
        public int Min = 50;
        public static Random A = new Random();

        public Villageois(String nom, double poids, Boolean malade)
        {

            this.nom = nom;
            this.poids = A.Next(50,150);








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


    }
    }
