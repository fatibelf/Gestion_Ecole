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
   public class ContrellerFormateur
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Formateur formateur)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Formateur where Id_formateur=" + formateur.ID_FORMATEUR, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Formateur values(@id,@cin,@Nom,@Prenom,@email,@telephone)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", formateur.ID_FORMATEUR));
                cmd.Parameters.Add(new SqlParameter("@cin", formateur.CIN));
                cmd.Parameters.Add(new SqlParameter("@Nom", formateur.NOM));
                cmd.Parameters.Add(new SqlParameter("@Prenom", formateur.PRENOM));
                cmd.Parameters.Add(new SqlParameter("@email", formateur.EMAIL));
                cmd.Parameters.Add(new SqlParameter("@telephone", formateur.TEL));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Formateur where Id_formateur =@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Formateur formateur)
        {
            cnx.Open();
            cmd = new SqlCommand("update formateur set  cin=@cin,nom=@nom,Prenom=@Prenom,email=@email,telephone=@telephone where id=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", formateur.ID_FORMATEUR));
            cmd.Parameters.Add(new SqlParameter("@cin", formateur.CIN));
            cmd.Parameters.Add(new SqlParameter("@Nom", formateur.NOM));
            cmd.Parameters.Add(new SqlParameter("@Prenom", formateur.PRENOM));
            cmd.Parameters.Add(new SqlParameter("@email", formateur.EMAIL));
            cmd.Parameters.Add(new SqlParameter("@telephone", formateur.TEL));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from formateur", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from formateur where Id_formateur =" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }


    }
}

