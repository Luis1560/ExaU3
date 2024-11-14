using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExaU3.Controller;

namespace ExaU3.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ControllerUsuario cntrl = new ControllerUsuario();
            if (cntrl.LoginUser(txtUsername.Text, txtPassword.Text))
            {
                Session["nombreusuario"] = txtUsername.Text;
                Response.Redirect("Agregar.aspx");
            }
            else
            {
                string script = "alert('No fue posible iniciar sesion, revisa usuario y contraseña');";
                ClientScript.RegisterStartupScript(this.GetType(), "LoginFailAlert", script, true);
            }
        }
    }
}