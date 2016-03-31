using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TD2_Prog
{
    class Program
    {
        static void Main(string[] args)
        {

            int choix = 1;

            do
            {

                menu(ref choix);
            } while (choix != 0);

            
        }

        public static void menu(ref int choix)
        {
            Console.Clear();
            string ecoute;
            do
            {
                Console.Write("Sélectionnez un exercice entre 1 et 6. \nSélectionnez 0 pour sortir.\n");
                ecoute = Console.ReadLine();
            } while (!conversion(ecoute, ref choix));
            Lancer(choix);
        }

        public static bool conversion(string s, ref int num)
        {
            if (Int32.TryParse(s, out num))
                return true;

            else
            {
                Console.WriteLine("Erreur de conversion.");
                return false;
            }
        }

        private static void Lancer(int choix)
        {
            switch (choix)
            {
                case 1:
                    {
                        Console.Write("Exercice 1 : Votre Chat a-t-il besoin d'un régime?\nAppuyez sur entrée pour démarrer.\n");
                        Console.ReadLine();
                        exercice1();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 2:
                    {
                        Console.Write("Exercice 2 : Les villageois.\n");
                        Console.ReadLine();
                        //exercice2();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 3:
                    {
                        Console.Write("Exercice 3 : Les ouvrages.\n");
                        Console.ReadLine();
                        exercice3();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 4:
                    {
                        Console.Write("Exercice 4 : Prise en main des listes.\n");
                        Console.ReadLine();
                        exercice4();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 5:
                    {
                        Console.Write("Exercice 5 : .\nAppuyez sur entrée pour démarrer.\n");
                        Console.ReadLine();
                        //exercice5();
                        Console.Write("\nFin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.Write("Exercice 6 : .\nAppuyez sur entrée pour démarrer.\n");
                        Console.ReadLine();
                        //exercice6();
                        Console.Write("\nFin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 0:
                    {
                        Console.WriteLine("Fin du menu. Tapez entrée pour finir le programme.");
                        Console.ReadLine();
                        break;
                    }
            }
        }




        public static void exercice1()
        {
            Console.WriteLine("Comment s'appelle votre chat?");
            string a = Console.ReadLine();
            Console.WriteLine("Quel est son poids en Kg?");
            double b = double.Parse(Console.ReadLine());
            Console.Clear();
            Chat C1;
            C1 = new Chat(a, b);
            Console.WriteLine(C1);
            Console.WriteLine(C1.Croquettes(b));
            Console.ReadKey();
            //Console.WriteLine(C1.nom);
            //Console.WriteLine(C1.poids);
        }

        public static void exercice2()
        {

        }

        public static void exercice3()
        {
            Console.WriteLine("Si votre ouvrage possède :\n");
            Console.WriteLine("Juste un auteur et un titre, tapez 1");
            Console.WriteLine("Possède en plus un nombre de pages, tapez 2");
            Console.WriteLine("Possède en plus un nom d'editeur mais pas de nombre de pages, tapez 3");
            Console.WriteLine("Possède un auteur, un titre, un nombre de pages et un editeur, tapez 4");
            Console.WriteLine("Si votre ouvrage s'agit d'une revue, tapez 5");
            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                Console.WriteLine("Nom de l'auteur : \n");
                string a = Console.ReadLine();
                Console.WriteLine("Titre de l'Ouvrage : \n");
                string b = Console.ReadLine();
                Console.Clear();
                Ouvrage O1;
                O1 = new Ouvrage(a, b);
                Console.WriteLine(O1.message());
                Console.ReadKey();
            }
            else if(i == 2)
            {
                Console.WriteLine("Nom de l'auteur : \n");
                string a = Console.ReadLine();
                Console.WriteLine("Titre de l'Ouvrage : \n");
                string b = Console.ReadLine();                
                Console.WriteLine("Nombres de pages :  \n");
                double d = double.Parse(Console.ReadLine());
                Console.Clear();
                Ouvrage O1;
                O1 = new Ouvrage(a, b, "", d);
                Console.WriteLine(O1.message());
                Console.ReadKey();
            }
            else if(i == 3)
            {
                Console.WriteLine("Nom de l'auteur : \n");
                string a = Console.ReadLine();
                Console.WriteLine("Titre de l'Ouvrage : \n");
                string b = Console.ReadLine();
                Console.WriteLine("Editeur : \n");
                string c = Console.ReadLine();                               
                              
                Console.Clear();
                Ouvrage O1;
                O1 = new Ouvrage(a, b, c);
                Console.WriteLine(O1.message());
                Console.ReadKey();
            }
            else if(i == 4)
            {
                Console.WriteLine("Nom de l'auteur : \n");
                string a = Console.ReadLine();
                Console.WriteLine("Titre de l'Ouvrage : \n");
                string b = Console.ReadLine();
                Console.WriteLine("Editeur : \n");
                string c = Console.ReadLine();
                Console.WriteLine("Nombres de pages :  \n");
                double d = double.Parse(Console.ReadLine());
                Console.Clear();
                Ouvrage O1;
                O1 = new Ouvrage(a, b, c, d);
                Console.WriteLine(O1.message());
                Console.ReadKey();
            }
            else if (i == 5)
            {
                Console.WriteLine("Nom de l'auteur : \n");
                string a = Console.ReadLine();
                Console.WriteLine("Titre de l'Ouvrage : \n");
                string b = Console.ReadLine();
                Console.WriteLine("Editeur : \n");
                string c = Console.ReadLine();
                Console.WriteLine("Nombres de pages :  \n");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Mois de parution : \n");
                string e = Console.ReadLine();
                Console.WriteLine("Annee de parution :  \n");
                int f = int.Parse(Console.ReadLine());
                Console.Clear();
                Revue R1;
                R1 = new Revue(a, b, c, d, e, f);
                Console.WriteLine(R1.message());
                Console.ReadKey();
            }
            else
            {
                exercice3();
            }

          


        }

        public static void exercice4()
        {
            Console.WriteLine("Creation de la liste dénommée 'ints'.\n");
            //ints ==> nom de la liste
            List<double> ints = new List<double>();

            //Création de la liste
            ints.Add(1.0);
            ints.Add(2.0);
            ints.Add(3.0);

            foreach (double i in ints)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();


            Console.WriteLine("Ajout de 4 à la liste dénommée 'ints'.\n");
            //Ajout à la liste
            ints.Add(4.0);

            foreach (double i in ints)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();

            Console.WriteLine("Insertion de 5 à la deuxième position de la liste dénommée 'ints'.\n");
            //Insertion dans la liste
            ints.Insert(2,5.0);

            for (int i = 0; i < ints.Count; ++i)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Suppression de la 4ème position de la liste dénommée 'ints'.\n");
            //Suppression dans la liste
            ints.RemoveAt(4);

            for (int i = 0; i < ints.Count; ++i)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Tri de la liste dénommée 'ints'.\n");
            //Tri dans la liste
            ints.Sort();
            for (int i = 0; i < ints.Count; ++i)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Inversion de l'ordre de la liste dénommée 'ints'.\n");
            //Inversion dans la liste
            ints.Reverse();
            for (int i = 0; i < ints.Count; ++i)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadLine();
        }
    }
}
