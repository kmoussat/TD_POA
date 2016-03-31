using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4
{
    class Program
    {
        static void Main(string[] args)
        {

            Lecture l1 = new Lecture();
            l1.lecture("liste1.txt");
           // l1.affichage();
            Lecture l2=new Lecture();
            l2.lecture("liste2.txt");

           // l2.affichage();
            l1.Suppression();
          
            l1.affichage();
            l1.recherche("Oliv");
            //var l3=l1.Liste.Union(l2.Liste).ToList();
            //foreach(var E in l3)
            //{
            //    Console.WriteLine(E.ToString());
            //}
            //Console.WriteLine(l3.Count.ToString());
           
            
            //var l4 = l1.Liste.Union(l2.Liste).ToList();
            //Console.WriteLine(l4.Count.ToString());
            Console.ReadLine();

            
            
        }
    }
}
