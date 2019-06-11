using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio10
{
    public partial class WebListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Weather> climas;
            //  Existe un listado?
            if (Session["listado"]!=null) // Session es un "diccionario".
            {
                // si: leemos el listado
                climas =(List<Weather>) Session["listado"];
            } else
            {
                // no: creamos un listado.
                climas=new List<Weather>();
                Session["listado"]=climas; // y guardamos la lista en la sesion
            }
            GridView1.DataSource=climas;
            GridView1.DataBind(); // <-- esto es necesario para refrescar.

            // SESIONES.
            // Como funciona?
            // a) yo me conecto a una pagina. Si no tengo un token (identificador)
            //   el sistema me crea uno, y me lo devuelve.
            // b) la proxima vez que me conecto a la pagina, envio el token
            //   automaticamente (llamado cookie)


        }
    }
}