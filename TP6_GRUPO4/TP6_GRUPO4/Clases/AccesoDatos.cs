using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO4.Clases
{
    public class AccesoDatos
    {
        String RutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";

        public AccesoDatos()
        {
        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(RutaBD);

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(string consulta)
        {
            SqlDataAdapter adap;

            try
            {
                adap = new SqlDataAdapter(consulta, ObtenerConexion());
                return adap;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int EjecutarAlmacenamiento(SqlCommand comando, String nombrePA)
        {
            int filasCambiadas;

            SqlConnection cn = ObtenerConexion();

            SqlCommand cmd = new SqlCommand();

            cmd = comando;

            cmd.Connection = cn;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombrePA;

            filasCambiadas = cmd.ExecuteNonQuery();

            cn.Close();

            return filasCambiadas;
        }
    }
}