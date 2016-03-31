using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2_Prog
{
    class Etagere
    {
        private List<Ouvrage> _ouvrages = new List<Ouvrage>();
        public List<Ouvrage> Ouvrage
        {
            get { return _ouvrages; }
            set { _ouvrages = value; }
        }
     
      
    }
}
