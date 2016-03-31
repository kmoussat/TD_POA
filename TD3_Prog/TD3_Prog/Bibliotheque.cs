using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3_Prog
{
    class Bibliotheque
    {
        private List<Etagere> listetag;
    

        public Bibliotheque()
        {
            this.listetag = new List<Etagere>();
          
        }

     
        public void AjouterEtagere(Etagere etag)
        {
            listetag.Add(etag);
        }

        public override string ToString()
        {
            return "tostring redefini";
        }

    }
}
