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
   public class ContrellerTypePaiment
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Module module)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Module where Id_modul=" + module.ID_MODULE, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Module values(@id,@Nom,@nbrheur,@idformateur)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", module.ID_MODULE));
                cmd.Parameters.Add(new SqlParameter("@Nom", module.NOM));
                cmd.Parameters.Add(new SqlParameter("@nbrheur", module.NBR_HEUR));
                cmd.Parameters.Add(new SqlParameter("@idformateur", module.ID_FORMATEUR));

                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Module where Id_formateur =@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Classe classe)
        {
            cnx.Open();
            cmd = new SqlCommand("update Module set  Nom_modul=@nom,Nbr_heur=@nbrheur,Id_formateur=@idformateur where Id_modul=@id", cnx);
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
            da = new SqlDataAdapter("select * from Module ", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Module where =Id_modul" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
    }
}
