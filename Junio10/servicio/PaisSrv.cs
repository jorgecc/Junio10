using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace Junio10.servicio
{
    public class PaisSrv
    {
        public static void Insertar(Pais pais,HttpSessionState sesion)
        {
            List<Pais> climas =ListarTodo(sesion); // leemos
            climas.Add(pais); // agregamos
            sesion["llavepais"] = climas; // guardamos la sesion

        }
        public static Pais Factory(TextBox txtid,TextBox txtNombre)
        {
            
            Pais nuevoPais=new Pais();
            nuevoPais.PaisId=Convert.ToInt32(txtid.Text);
            nuevoPais.Nombre=txtNombre.Text;
            return nuevoPais;
        }
        public static List<Pais> ListarTodo(HttpSessionState sesion)
        {
            if (sesion["llavepais"] !=null)
            {
                return (List<Pais>)sesion["llavepais"];
            } else
            {
                return new List<Pais>();
            }
            
        }
    }
}