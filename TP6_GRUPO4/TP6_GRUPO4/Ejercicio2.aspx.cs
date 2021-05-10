using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using TP6_GRUPO4.Clases;

namespace TP6_GRUPO4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cargarGridView();
            }
        }

        public void cargarGridView()
        {
               GestionProductos gProductos = new GestionProductos();
               grdProductos.DataSource = gProductos.ObtenerTodosLosProductos();
               grdProductos.DataBind();
        }

       /* protected void grdProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            String s_NombreProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            String s_IdProveedor = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            String s_PrecioUnidad = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnidad")).Text;

            lblAgregado.Text = "Producto agregado: "+s_NombreProducto;
        }*/
    }
}