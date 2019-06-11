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
    public partial class WebFormInsertarPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            // 2) leer los valores de los cuadros de texto y guardarlos en el objeto
            pais = PaisSrv.Factory(TextBoxId, TextBoxNombre);
            // 3) agregar el objeto a la lista
            PaisSrv.Insertar(pais, Session);
            // 4) devolvernos a la pagina de la lista
            Response.Redirect("WebFormListarPais.aspx");

        }
    }
}