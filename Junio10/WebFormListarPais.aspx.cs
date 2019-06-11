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
    public partial class WebFormListarPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Pais> pais = PaisSrv.ListarTodo(Session);

            GridView1.DataSource = pais;
            GridView1.DataBind();
        }
    }
}