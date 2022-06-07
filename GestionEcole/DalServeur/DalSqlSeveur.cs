using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEcole.DalServeur
{
    public class DalSqlSeveur
    {
        public SqlConnection ConexionBD { get; set; }

        public DalSqlSeveur()
        {
            ConexionBD = new SqlConnection(@"Data Source=DESKTOP-KQ6DGTN\SQLEXPRESS;Initial Catalog=GestionEcol;Integrated Security=True");
        }
    }
}
