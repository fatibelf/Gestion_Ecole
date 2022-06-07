using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole.Model
{
   public class Formateur
    {
        public int ID_FORMATEUR { get; set; }
        public string CIN { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string EMAIL { get; set; }
        public string TEL { get; set; }
    }
}
