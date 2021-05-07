using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO4.Clases
{
    public class Productos
    {
        private int i_IdProducto;
        private string s_NombreProducto;
        private string s_CantidadPorUnidad;
        private decimal d_PrecioUnidad;

        public Productos()
        {
        }

        public Productos(int i_IdProducto, string s_NombreProducto, string s_CantidadPorUnidad, decimal d_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.s_NombreProducto = s_NombreProducto;
            this.s_CantidadPorUnidad = s_CantidadPorUnidad;
            this.d_PrecioUnidad = d_PrecioUnidad;
        }

        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }

        public string NombreProducto
        {
            get { return s_NombreProducto; }
            set { s_NombreProducto = value; }
        }

        public string CantidadUnidad
        {
            get { return s_CantidadPorUnidad; }
            set { s_CantidadPorUnidad = value; }
        }

        public decimal PrecioUnidad 
        {
            get { return d_PrecioUnidad; }
            set { d_PrecioUnidad = value; }
        }
    }
}