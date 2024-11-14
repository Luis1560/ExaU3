using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExaU3.Controller;

namespace ExaU3.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreusuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                ControllerProducto cntrl = new ControllerProducto();
                gvProductos.DataSource = cntrl.ObtenerProductos();
                gvProductos.Visible = true;
                gvProductos.DataBind();
            }
        }
    }
}