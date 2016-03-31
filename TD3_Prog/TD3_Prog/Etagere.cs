using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Etagere
    {
        private List<Document> listdoc;
        private int nbdispo;

        public Etagere(int taille)
        {
            this.listdoc = new List<Document>();
            this.nbdispo = taille;
        }

        public int taille
        {
            get { return nbdispo; }
        }

        public void AjouterDocument(Document doc)
        {
            listdoc.Add(doc);
            Nbplace = nbdispo - 1;
        }

        public override string ToString()
        {
            return "tostring redefini";
        }

        public int Nbplace
        {
            get { return nbdispo; }
            set { nbdispo = value; }
        }
    }
}
