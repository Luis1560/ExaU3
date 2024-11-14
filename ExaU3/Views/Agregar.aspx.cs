using ExaU3.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExaU3.Views
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreArchivo = System.IO.Path.GetFileName(fileImagen.FileName);
            string rutaImagen = "~/images/"+nombreArchivo;

            ControllerProducto ctrl = new ControllerProducto();
            if (ctrl.AgregarVideojuego(txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text), rutaImagen))
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}