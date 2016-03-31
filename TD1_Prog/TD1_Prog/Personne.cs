using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Prog
{

    //Exercice 1
    //constructeur
    public class Personne
    {
        public string nom;
        public string prenom;
        public bool genre;
        public int bday;
        public string status;


        public Personne(string nom, string prenom, bool genre, int bday, string status)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.bday = bday;
            this.status = status;

        }

        
        //Exercice 4
        public string Nom
        {
            get { return nom; }
        }


        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

       

        public int Age
        {
            get { return DateTime.Today.Year - bday; }
            set { bday = value; }
        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        //Exercice 5
        public int RetournerAgeEn(int anneeRef)
        {
            int age;
            if (anneeRef >= bday)
            {
                age = anneeRef - bday;
            }
            else
            {
                age = 0;
            }
            return age;
        }

        //Exercice 6
        public Boolean PlusVieuxQue(int ageRef)
        {

            bool plusoumoins;
            if (bday >= ageRef)
            {
                plusoumoins = true;
               
            }
            else
            {
                plusoumoins = false;
            }
            return plusoumoins;
        }

        public Boolean PlusVieuxQue(Personne pRef)
        {
            bool plusoumoins;
            if (bday < pRef.bday)
            {
                plusoumoins = true;
            }
            else
            {
                plusoumoins = false;
            }
            return plusoumoins;
        }


        //Exercice 7
       
       public bool Genre
       {
           get { return genre; }
            set { genre = value; }
       }
       

        public void Afficher()
        {
            if (Genre == false)
            {
                Console.WriteLine(nom + " " + prenom + "est né en " + bday + ", il est " + status);
             }
            else
            {
                Console.WriteLine(nom + " " + prenom + "est née en " + bday + ", elle est " + status);
             }


        }


        //Exercice 8

        public Personne(string nom, string prenom, bool genre, int bday)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.bday = bday;
            this.status = "inconnu";

        }

        //Exercice 9


        //Exercice 10

        public String message()
        {
            if (Genre == false)
            {
                string birth = bday.ToString();
                string message = Nom + " " + Prenom + " " + " est né en " + bday + ", il est " + status;

                return message;
            }
            else
            {
                string birth = bday.ToString();
                string message = Nom + " " + Prenom + " " + " est née en " + bday + ", elle est " + status;

                return message;
            }


        }

        //Exercice 11

        public override string ToString()
        {
            return "ToString est redéfini";
        }



        /*

        public string Nom
        {
            get { return nom; }
        }


        class AddPersonne
        {
            static void Main()
            {
               Personne P = new Personne(string, string, bool, int, string);

               Console.WriteLine("Nom: {0}", "Prenom: {0}", "Sexe {0}", "Date de Naissance: {1}", "Statut: {0}", Personne.nom, Personne.prenom, Personne.genre, Personne.bday, Personne.status);
                // Keep the console window open in debug mode.
                Console.WriteLine("Presser n'importe quelle touche pour quitter.");
                Console.ReadKey();
            } 

    }*/
    }
}
