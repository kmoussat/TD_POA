using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Prog
{

    //Exercice 12
    public class Point
    {
        public override string ToString()
        {
            return " ToString est redefini ";
        }
        private double x;
        private double y;

        // Constructeur avec argument
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Translater(double dx, double dy)
        {
            x = x + dx;
            y = y + dy;
        }


        public double DistanceOrigine()
        {
            double dist;
            dist = Math.Sqrt(x * x + y * y);
            return dist;
        }
            //Exercice 13
            /*
            Object: toString(): String
            Point dont la valeur est nulle

            Point
            =====
            x: double
            y: double
            ------
            Translater():  DOuble
            DistanceOrigine(): Double
            ToString(): String
            
        */

    }
}
