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
    public class ContrellerStagaire
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Stagaire stagaire)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from stagaire where id=" + stagaire.ID, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into stagaire values(@id,@cin,@Nom,@Prenom,@Adresse,@telephone,@email,@datenaissance,@niveauscolaire)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", stagaire.ID));
                cmd.Parameters.Add(new SqlParameter("@cin", stagaire.CIN));
                cmd.Parameters.Add(new SqlParameter("@Nom", stagaire.NOM));
                cmd.Parameters.Add(new SqlParameter("@Prenom", stagaire.PRENOM));
                cmd.Parameters.Add(new SqlParameter("@Adresse", stagaire.ADRESSE));
                cmd.Parameters.Add(new SqlParameter("@telephone", stagaire.TELE));
                cmd.Parameters.Add(new SqlParameter("@email", stagaire.EMAIL));
                cmd.Parameters.Add(new SqlParameter("@datenaissance", stagaire.DATENAISSANCE));
                cmd.Parameters.Add(new SqlParameter("@niveauscolaire", stagaire.NIVEAUSCOLAIRE));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from stagaire where id=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Stagaire stagaire)
        {
            cnx.Open();
            cmd = new SqlCommand("update stagiare set  cin=@cin,nom=@nom,Prenom=@Prenom,adress=@adress,telephone=@telephone,email=@email,datenaissance=@datenaissance,niveauscolaire=@niveauscolaire where id=@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", stagaire.ID));
            cmd.Parameters.Add(new SqlParameter("@cin", stagaire.CIN));
            cmd.Parameters.Add(new SqlParameter("@Nom", stagaire.NOM));
            cmd.Parameters.Add(new SqlParameter("@Prenom", stagaire.PRENOM));
            cmd.Parameters.Add(new SqlParameter("@Adresse", stagaire.ADRESSE));
            cmd.Parameters.Add(new SqlParameter("@telephone", stagaire.TELE));
            cmd.Parameters.Add(new SqlParameter("@email", stagaire.EMAIL));
            cmd.Parameters.Add(new SqlParameter("@datenaissance", stagaire.DATENAISSANCE));
            cmd.Parameters.Add(new SqlParameter("@niveauscolaire", stagaire.NIVEAUSCOLAIRE));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from stagiare", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from stagiare where id=" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }


    }
}

