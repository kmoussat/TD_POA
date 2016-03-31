using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4
{
    class Lecture
    {
        private List<Telephone> liste;

        public Lecture()
        {
            liste = new List<Telephone>();
        }

        public List<Telephone> Liste
        {
            get { return liste; }
        }


        public void lecture(string lis)
        {

            StreamReader monStreamReader = new StreamReader(@""+lis);

            string ligne = monStreamReader.ReadLine();

            // Tant que la ligne lue n'est pas null
            while (ligne != null)
            {
                
                    // Découper selon le séparateur ',', résultat: un tableau.
                    string[] temp = ligne.Split(',');
                   
                    // Si telephone fixe
                    if (temp[0] == "Fixe")
                    {
                    try
                    {
                        Fixe fix;
                        fix = new Fixe(temp[1], temp[2], temp[3]);
                        liste.Add(fix);
                    } catch (Exception)
                {
                    Console.WriteLine("Une ligne a une erreur");
                }

            }
                    else // sinon, telephone portable.
                    {
                    try {
                        Portable port = new Portable(temp[1], temp[2], temp[3]);
                        liste.Add(port);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Une mauvaise ligne de le fichier");
                    }
                    }

                    // lire ligne suivante.
                    ligne = monStreamReader.ReadLine();
               

                // Fermeture du StreamReader (attention indispensable) 
                

            }
            monStreamReader.Close();

        }

        public void affichage()
        {
            liste= liste.OrderBy(x => x.Numero).ToList();
            foreach(var E in liste)
            {
                Console.WriteLine(E.ToString());
                
                
            }
                
             
        }
        
        public void Suppression()
        {
            int leng = liste.Count;
            

            for (int i = 0; i < leng; i++)
            {
                if (liste != null)
                {
                    try
                    {

                        if (liste[i].Numero.Length < 11)
                        {

                            liste.RemoveAt(i);

                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
              
        }
        public void recherche(string recherch)
        {
            int i = 1;
            var listd = new Dictionary<string,int>();
            foreach(var E in liste)
            {
                listd.Add(E.ToString(), i);
                i+= 1;
            }

            foreach(var E in listd)
            {
                if (E.Key.Contains(recherch))
                {
                    Console.WriteLine(E.Key.ToString());
                }

                }
            }
                
        }
    }

