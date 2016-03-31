using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TD4_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Streamread S1 = new Streamread();
            S1.streamread("liste1.txt");
            Streamread S2 = new Streamread();
            S2.streamread("liste2.txt");
           // var SU = S1.Tel.Union(S2.Tel);
           

            S1.Display();
            S1.Tel.Sort();
            Console.WriteLine("TRI\n");
            S1.Search("Jean");
            S1.Display();
            S1.Write();

           
            

            //Streamread S2;
           // S2 = new Streamread(@"C:\Users\Ken\Documents\Visual Studio 2015\Projects\TD_POA\TD4_Prog\TD4_Prog\bin\Debug\liste2.txt");
// Console.WriteLine(S2);
            Console.ReadKey();
        }
    }
}
