using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2_Prog
{
    class Ouvrage
    {

        private String nom;
        private String titre;
        public String editeur;
        public double pages;


     
        public Ouvrage(string nom, string titre)
        {
            this.nom = nom;
            this.titre = titre;
        }

        public Ouvrage(string nom, string titre, double pages)
        {
            this.nom = nom;
            this.titre = titre;
            this.pages = pages;
        }

        public Ouvrage(string nom, string titre, string editeur)
        {
            this.nom = nom;
            this.titre = titre;
            this.editeur = editeur;
        }

        public Ouvrage(string nom, string titre, string editeur, double pages)
        {
            this.nom = nom;
            this.titre = titre;
            this.editeur = editeur;
            this.pages = pages;
        }

       

        public String Nom
        {
            get { return nom; }
        }

        public String Titre
        {
            get { return titre; }
        }

        public String Editeur
        {
            get { return editeur; }
        }

        public double Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public string message()
        {
            string pg = pages.ToString();
            if((Editeur == "")&&(pg == ""))
            {

                string message = "Auteur : " + nom + "\nTitre : " + titre;
                return message;
            }
            else if(Editeur == "")
            {
                string message = "Auteur : " + nom + "\nTitre : " + titre + "\nNombre de pages : " + pg;
                return message;
            }
            else if(pg == "")
            {
                string message = "Auteur : " + nom + "\nTitre : " + titre + "\nEditeur : " + editeur;
                return message;
            }
            else
            {
                string message = "Auteur : " + nom + "\nTitre : " + titre + "\nNombre de pages : " + pg + "\nEditeur : " + editeur;
                return message;
            }
        }


        public override string ToString()
        {
            return "ToString est redéfini";
        }


     

        }
    }

