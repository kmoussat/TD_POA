using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4_Prog
{
    public class Streamread
    {

        private List<Telephone> tel;

        public Streamread()
        {
            tel = new List<Telephone>();
        }

        public List<Telephone> Tel
        {
            get { return tel; }

        }
       
        public void streamread(string liste)
        {
            // Ouverture du fichier, 

            StreamReader monStreamReader = new StreamReader(@""+liste);
            string ligne = monStreamReader.ReadLine();


            // Lire la première ligne
           // string ligne = monStreamReader.ReadLine();

          


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
                        Telephone_fixe fix;
                        fix = new Telephone_fixe(temp[1], temp[2], temp[3]);
                        tel.Add(fix);
                    }catch(Exception)
                    {
                        Console.WriteLine("La ligne a une erreur");
                    }

                }
                else // sinon, telephone portable.
                {
                   
                    try
                    {
                        Telephone_portable portable = new Telephone_portable(temp[1], temp[2], temp[3]);
                        tel.Add(portable);
                    }catch(Exception)
                    {
                        Console.WriteLine("La ligne a une erreur");
                    }
                }

                // lire ligne suivante.
                ligne = monStreamReader.ReadLine();
            }




            // Fermeture du StreamReader (attention indispensable) 
            monStreamReader.Close();



        }
       
       
        public void Display()
        {
            //tel = tel.OrderBy(x => x.Numero).ToList();
            foreach(var E in tel)
            {
                Console.WriteLine(E.ToString());
            }
        }

        public void Delete()
        {
            int length = tel.Count;

            for(int i = 0; i < length; i++)
            {
                if (tel != null)
                {
                    try
                    {
                        if (tel[i].Numero.Length < 11)
                        {
                            tel.RemoveAt(i);
                        }
                    }

                    catch(Exception)
                    {

                    }
                }
            }
        }

        public void Search(string seek)
        {
            int i = 1;
            var telist = new Dictionary<string, int>();
            foreach(var E in tel)
            {
                telist.Add(E.ToString(), i);
                i += 1;
            }

            foreach(var E in telist)
            {
                if(E.Key.Contains(seek))
                {
                    Console.WriteLine(E.Key.ToString());
                }
            }
        }

        public void tri_proprietaire()
        {
            List<Telephone_portable> liste_portable = new List<Telephone_portable>();
            foreach (Telephone E in tel)
            {
                if (E.GetType().ToString() == "TD4.Portable")
                {
                    liste_portable.Add((Telephone_portable)E);


                }

            }
            liste_portable = liste_portable.OrderBy(x => x.Nom_proprio).ToList();
            foreach (Telephone_portable P in liste_portable)
            {
                Console.WriteLine(P.Nom_proprio);
            }

        }

        public void Write()
        {
            StreamWriter writer = new StreamWriter("nomDeSortie.txt");
            tel = Tel.OrderBy(x => x.Numero).ToList();
            foreach(Telephone E in tel)
            {
                writer.WriteLine(E);
            }
            writer.Close();
        }


    }

}