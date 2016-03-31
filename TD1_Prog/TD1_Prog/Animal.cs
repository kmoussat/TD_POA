using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Prog
{
    class Animal
    {
        private string nom;
        private string type;
        private bool genre;
        private int bday;
        private bool status;


        public Animal(string nom, string type, bool genre, int bday,  bool status)
        {
            this.nom = nom;
            this.type = type;
            this.genre = genre;
            this.bday = bday;
            this.status = status;

        }


        public string Nom
        {
            get { return nom; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }



        public int Age
        {
            get { return DateTime.Today.Year - bday; }
            set { bday = value; }
        }


        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }

}
