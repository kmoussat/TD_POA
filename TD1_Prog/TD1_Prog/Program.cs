using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Prog
{


    class nvlPersonne
    {
        static void Main()
        {

            //Exercice 2, 3
            Personne p1;
            Personne p2;
            p1 = new Personne("Holly", "Pierre", false, 1945, "celibataire");
            p2 = new Personne("Holl", "Pierr", false, 1941);
            //ex3: non valide
            //pas accessible à l'exterieur de la classe car private
            //Exercice 9
            Console.WriteLine(p1.Nom);
            Console.WriteLine(p1.Prenom);
            //Console.WriteLine(p1.bday);
            Console.WriteLine(p1.Age);
            p1.RetournerAgeEn(2016);
            p1.PlusVieuxQue(64);
            p1.PlusVieuxQue(p2);
            Console.WriteLine(p1.message());
            Console.WriteLine(p1);
            Console.ReadLine();

            Point pp1;
            // p1 est un objet de la classe
            //Point dont la valeur est null
            pp1 = new Point(1, 2);
            // p1 est instancie par le
            //constructeur par defaut
            // p1.x = 2;
            // Expression interdite car x est
            // un attribut prive
            pp1.Translater(1, 2);
            // Expression permise
            Console.WriteLine(pp1.DistanceOrigine());
            // Affiche la Distance a l’ origine

            Console.ReadKey();



            //Console.ReadKey();
        }
    }

    /*
    class nvPoint
    {
        static void Main2()
        {
            Point pp1;
            // p1 est un objet de la classe
            //Point dont la valeur est null
                pp1 = new Point();
            // p1 est instancie par le
            //constructeur par defaut
           // p1.x = 2;
            // Expression interdite car x est
           // un attribut prive
            pp1.Translater(1, 2);
            // Expression permise
            Console.WriteLine(pp1.DistanceOrigine());
            // Affiche la Distance a l’ origine

            Console.ReadKey();



        }
    }
    */
  
}