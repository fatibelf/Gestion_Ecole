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
   public class ContrellerPaiment
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Paiment paiment)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Paiment  where Id_paiment =" + paiment.ID_STAGAIR, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Paiment values(@id,@montant,@avance,@datepaiment,@idstagair,@idtypepayment)", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", paiment.ID_PAIMENT));
                cmd.Parameters.Add(new SqlParameter("@montant", paiment.MONTANT));
                cmd.Parameters.Add(new SqlParameter("@avance", paiment.AVANCE));
                cmd.Parameters.Add(new SqlParameter("@datepaiment", paiment.DATE_PAIMENT));
                cmd.Parameters.Add(new SqlParameter("@idstagair", paiment.ID_STAGAIR));
                cmd.Parameters.Add(new SqlParameter("@idtypepayment", paiment.ID_TYPE_PAYMENT));

                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Paiment where Id_paiment =@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Paiment paiment)
        {
            cnx.Open();
            cmd = new SqlCommand("update Paiment set Montant=@montant,Avance=@avance,Date_paiment =@datepaiment,Id_stagaire =@idstagair,Id_type_paiment=@idtypepayment where Id_paiment =@id", cnx);
            cmd.Parameters.Add(new SqlParameter("@id", paiment.ID_PAIMENT));
            cmd.Parameters.Add(new SqlParameter("@montant", paiment.MONTANT));
            cmd.Parameters.Add(new SqlParameter("@avance", paiment.AVANCE));
            cmd.Parameters.Add(new SqlParameter("@datepaiment", paiment.DATE_PAIMENT));
            cmd.Parameters.Add(new SqlParameter("@idstagair", paiment.ID_STAGAIR));
            cmd.Parameters.Add(new SqlParameter("@idtypepayment", paiment.ID_TYPE_PAYMENT));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Paiment", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Paiment where Id_paiment=" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }


    }
}

