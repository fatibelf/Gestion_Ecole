using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole.Model
{
   public class Module
    {
        public int ID_MODULE { get; set; }
        public string NOM { get; set; }
        public int NBR_HEUR { get; set; }
        public int ID_FORMATEUR { get; set; }
    }
}
