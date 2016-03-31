using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
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
                Console.Write(" Sélectionnez 1 pour un livre\n Sélectionnez 2 pour une revue\n Sélectionnez 3 pour un dictionnaire  \n Sélectionnez 0 pour sortir.\n");
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
                        Console.Write("Votre document est un livre.\n");
                        Console.ReadLine();
                        exercice1();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 2:
                    {
                        Console.Write("Votre document est une revue\n");
                        Console.ReadLine();
                        //exercice2();
                        Console.WriteLine("Fin de l'exercice. Tapez entrée pour retourner au menu.");
                        Console.ReadLine();
                        break;
                    }

                case 3:
                    {
                        Console.Write("Votre document est un dictionnaire.\n");
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
           
        }

        public static void exercice2()
        {

        }

        public static void exercice3()
        {
          
        }

        public static void exercice4()
        {
            
        }
    }
}
