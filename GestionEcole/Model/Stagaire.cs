using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole.Model
{
    public class Stagaire
    {
        public int ID { get; set; }
        public string CIN { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string ADRESSE { get; set; }
        public string TELE { get; set; }
        public string EMAIL { get; set; }
        public DateTime DATENAISSANCE { get; set; }
        public string NIVEAUSCOLAIRE { get; set; }  
    }
}
