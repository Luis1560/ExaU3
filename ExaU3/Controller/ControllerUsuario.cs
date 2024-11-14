using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExaU3.Controller;
using ExaU3.Models.DataSet1TableAdapters;

namespace ExaU3.Controller
{
    public class ControllerUsuario
    {
        public bool LoginUser(string user, string pass)
        {
            try
            {
                using (usuariosTableAdapter users = new usuariosTableAdapter())
                {
                    var filaUser = users.GetDataByUsuario(user.Trim().ToLower());

                    if (filaUser.Rows.Count > 0)
                    {
                        string contraEncriptada = filaUser.Rows[0]["contrasena"].ToString();

                        AESCryptography aES = new AESCryptography();
                        string contraDesencriptada = aES.Decrypt(contraEncriptada);

                        if (contraDesencriptada == pass && filaUser.Rows[0]["nombre_usuario"].ToString() == user)
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
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}
