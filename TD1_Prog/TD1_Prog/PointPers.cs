using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Prog
{
    public class PointPers //: Personne
    {

        private Point pt2;
        private Personne p1;

        public void personne(string nom, string prenom, int naissance, bool genre)
        {
            p1 = new Personne(nom, prenom, genre, naissance);

        }
        //public Pers_Pos(string nom, string prenom, bool genre, int naissance)
        //{
        //    Nom = nom;
        //    Prenom = prenom;
        //    genre = true;
        //    Naissance = 1961;
        //}
        public void init(double x, double y)
        {
            pt2 = new Point(x, y);

        }
    }
}