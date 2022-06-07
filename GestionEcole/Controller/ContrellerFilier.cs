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
    public class ContrellerFilier
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Filier filier)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Filier where Id_filier =" + filier.ID_FILIER, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Filier values(@id,@Nom,@iddiplomme)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", filier.ID_FILIER));
                cmd.Parameters.Add(new SqlParameter("@cin", filier.NOM_FILIER));
                cmd.Parameters.Add(new SqlParameter("@Nom", filier.ID_DIPLOM));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Filier where Id_filier=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Filier filier)
        {
            cnx.Open();
            cmd = new SqlCommand("update Filier set Nom_filier=@nom,Id_diplom =@idmodul where Id_filier =@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", filier.ID_FILIER));
           
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Filier", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Filier where Id_filier =" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }


    }
}

