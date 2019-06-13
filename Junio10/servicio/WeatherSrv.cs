using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace Junio10.servicio
{
    public class WeatherSrv
    {
        public static void Insertar(Weather clima,HttpSessionState sesion)
        {
            List<Weather> climas =ListarTodo(sesion); // leemos
            climas.Add(clima); // agregamos
            sesion["listado"] = climas; // guardamos la sesion

        }
        public static Weather Factory(TextBox txtid
                ,TextBox txtFecha
                , DropDownList comboEstado
                ,DropDownList comboUbicacion)
        {
            
            Weather nuevoClima=new Weather();
            nuevoClima.Pais=new Pais(); 
            nuevoClima.WeatherId=Convert.ToInt32(txtid.Text);
            nuevoClima.Fecha=txtFecha.Text;

            nuevoClima.Estado.EstadoId = Convert.ToInt32(
                 comboEstado.SelectedItem.Value);
            nuevoClima.Estado.Nombre = comboEstado.SelectedItem.Text;


            nuevoClima.Pais.PaisId=Convert.ToInt32(
                    comboUbicacion.SelectedItem.Value);
            nuevoClima.Pais.Nombre=comboUbicacion
                .SelectedItem.Text;
            return nuevoClima;
        }
        public static List<Weather> ListarTodo(HttpSessionState sesion)
        {
            if (sesion["listado"]!=null)
            {
                return (List<Weather>)sesion["listado"];
            } else
            {
                return new List<Weather>();
            }
            
        }
    }
}