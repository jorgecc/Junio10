using Junio10.Models;
using Junio10.servicio;
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
            List<Weather> climas=WeatherSrv.ListarTodo(Session);

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