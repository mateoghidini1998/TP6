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
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
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


        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_it_IdProducto")).Text;

            Productos pro = new Productos();
            pro.IdProducto = Convert.ToInt32(s_IdProducto);

            GestionProductos gProductos = new GestionProductos();
            gProductos.EliminarProducto(pro);

            cargarGridView();
        }

        protected void grdProductos_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            cargarGridView();
        }

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            lblMensajeNombre.Text = "";
            lblMensajeCantidad.Text = "";
            lblMensajePrecio.Text = "";
            grdProductos.EditIndex = e.NewEditIndex;
            cargarGridView();
        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            cargarGridView();
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            String s_NombreProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            String s_CantidadPorUnidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            String s_Precio = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_Precio")).Text;

           if (s_NombreProducto == "")
           {
                lblMensajeNombre.Text = "No se puede ingresar un campos vacio en el nombre del producto.";
                grdProductos.EditIndex = -1;
                cargarGridView();
                return;
           }
           if (s_CantidadPorUnidad == "")
           {
                lblMensajeCantidad.Text = "No puede ingresar un campo vacio en la cantidad.";
                grdProductos.EditIndex = -1;
                cargarGridView();
                return;
           }
            decimal precio = Convert.ToDecimal(s_Precio);
           if (precio <= 0)
            {
                lblMensajePrecio.Text = "No se ingresar un precio menor o igual a 0.";
                grdProductos.EditIndex = -1;
                cargarGridView();
                return;
            }


           Productos pro = new Productos();
           pro.IdProducto = Convert.ToInt32(s_IdProducto);
           pro.NombreProducto = s_NombreProducto;
           pro.CantidadUnidad = s_CantidadPorUnidad;
           pro.PrecioUnidad = Convert.ToDecimal(s_Precio);
           GestionProductos gProductos = new GestionProductos();
           gProductos.ActualizarProducto(pro);
           grdProductos.EditIndex = -1;
           cargarGridView();
        }
    }
}