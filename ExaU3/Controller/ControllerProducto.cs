using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExaU3.Models.DataSet1TableAdapters;

namespace ExaU3.Controller
{
    public class ControllerProducto
    {
       
        public bool AgregarVideojuego(string nombre, int cantidad, decimal precio, string img)
        {
            try
            {
                using (videojuegosTableAdapter videos = new videojuegosTableAdapter())
                {
                    videos.InsertarVideoJuego(nombre, cantidad, precio, img);
                }
            
                return true;
            }
            catch (Exception)
            {

                throw;
            }

            
        }
        public DataTable ObtenerProductos()
        {
            try
            {
                using (videojuegosTableAdapter videos = new videojuegosTableAdapter())
                {
                    return videos.GetData();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener la lista de productos: " + ex.Message);
            }
        }
    }
}