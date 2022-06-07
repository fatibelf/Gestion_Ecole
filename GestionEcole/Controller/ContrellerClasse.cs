using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEcole.DalServeur;
using GestionEcole.Model;
using System.Data.SqlClient;
using System.Data;

namespace GestionEcole.Controller
{
     public class ContrellerClasse
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Classe classe)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from classe where id=" + classe.ID_CLASSE, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into classe values(@id,@Nom,@etage,@capacite)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id",classe.ID_CLASSE));
                cmd.Parameters.Add(new SqlParameter("@Nom", classe.NOM));
                cmd.Parameters.Add(new SqlParameter("@etage", classe.ETAGE));
                cmd.Parameters.Add(new SqlParameter("@capacite", classe.CAPACITE));
                
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from classe where id_classe=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Classe classe)
        {
            cnx.Open();
            cmd = new SqlCommand("update classe set  nom=@nom,etage=@etage,capacite=@capacite where id_classe=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", classe.ID_CLASSE));           
            cmd.Parameters.Add(new SqlParameter("@nom", classe.NOM));
            cmd.Parameters.Add(new SqlParameter("@etage", classe.ETAGE));
            cmd.Parameters.Add(new SqlParameter("@capacite", classe.CAPACITE));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from classe", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from classe where id_classe=" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }

    }
}
