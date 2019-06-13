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
    public partial class WebInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                // solo cargar este codigo la primera vez
                DropDownList1.DataSource=PaisSrv.ListarTodo(Session);
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1) crear un objeto clima
            Weather clima=new Weather();
            // 2) leer los valores de los cuadros de texto y guardarlos en el objeto
            clima=WeatherSrv.Factory(TextBoxId, TextBoxFecha
                    , TextBoxEstado,DropDownList1);
            // 3) agregar el objeto a la lista
            WeatherSrv.Insertar(clima,Session);
            // 4) devolvernos a la pagina de la lista
            Response.Redirect("WebListar.aspx");

        }
    }
}