using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2_Prog
{
    class Revue
    {

        private String nom;
        private String titre;
        public String editeur;
        public double pages;
        public string mois;
        public int annee;



       public Revue(string nom, string titre, string editeur, double pages, string mois, int annee)
        {
            this.nom = nom;
            this.titre = titre;
            this.editeur = editeur;
            this.pages = pages;
            this.mois = mois;
            this.annee = annee;
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

        public String Mois
        {
            get { return mois; }
        }

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string message()
        {
            string pg = pages.ToString();
            string message = "Auteur : " + nom + "\nTitre : " + titre + "\nNombre de pages : " + pg + "\nEditeur : " + editeur + "\nDate de publication : " + mois + " " + annee;
            return message;
            
        }


        public override string ToString()
        {
            return "ToString est redéfini";
        }




    }
}

