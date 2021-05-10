using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO4.Clases
{
    public class GestionProductos
    {
        public GestionProductos()
        { 
        
        }

        private DataTable ObtenerTabla(String nombre, string Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos ad = new AccesoDatos();
            SqlDataAdapter adap = ad.ObtenerAdaptador(Sql);
            adap.Fill(ds, nombre);
            return ds.Tables[nombre];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "Select [IdProducto], [NombreProducto], [CantidadPorUnidad], " +
                "[PrecioUnidad] FROM Productos");
        }

        private void ArmarParametrosProductosEliminar(ref SqlCommand comando, Productos producto)
        {
            SqlParameter param = new SqlParameter();
            param = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            param.Value = producto.IdProducto;
        }

        private void ArmarParametrosProductos(ref SqlCommand cmd, Productos prod)
        {
            SqlParameter param = new SqlParameter();

            param = cmd.Parameters.Add("IdProducto", SqlDbType.Int);
            param.Value = prod.IdProducto;
            param = cmd.Parameters.Add("NombreProducto", SqlDbType.NVarChar, 40);
            param.Value = prod.NombreProducto; 
            param = cmd.Parameters.Add("CantidadPorUnidad", SqlDbType.NVarChar, 20);
            param.Value = prod.CantidadUnidad;
            param = cmd.Parameters.Add("PrecioUnidad", SqlDbType.Money);
            param.Value = prod.PrecioUnidad;
        }

        public bool ActualizarProducto(Productos prod)
        {
            SqlCommand cmd = new SqlCommand();
            ArmarParametrosProductos(ref cmd, prod);
            AccesoDatos ad = new AccesoDatos();
            int FilasCambiadas = ad.EjecutarAlmacenamiento(cmd, "Actualizar_Fila");

            if(FilasCambiadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarProducto(Productos prod)
        {
            SqlCommand cmd = new SqlCommand();
            ArmarParametrosProductosEliminar(ref cmd, prod);
            AccesoDatos ad = new AccesoDatos();
            int FilasCambiadas = ad.EjecutarAlmacenamiento(cmd, "Eliminar_Fila");

            if (FilasCambiadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}