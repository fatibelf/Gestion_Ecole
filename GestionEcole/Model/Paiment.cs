using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole.Model
{
    public class Paiment
    {
        public int ID_PAIMENT { get; set; }
        public float MONTANT { get; set; }
        public float AVANCE { get; set; }
        public DateTime DATE_PAIMENT { get; set; }
        public int ID_STAGAIR { get; set; }
        public int ID_TYPE_PAYMENT { get; set; }
    }
}
