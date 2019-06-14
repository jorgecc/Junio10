<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebInsertar.aspx.cs" Inherits="Junio10.WebInsertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="#">Navbar</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="WebFormInsertarPais.aspx">Insertar Pais</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="WebFormListarPais.aspx">Listar Pais</a>
      </li>
           <li class="nav-item">
        <a class="nav-link" href="WebInsertar.aspx">Insertar Clima</a>
      </li>
              <li class="nav-item">
        <a class="nav-link" href="WebListar.aspx">Listar Clima</a>
      </li>
    </ul>
  </div>
</nav>


    <form id="form1" runat="server">
        <div>
            Id: 
            <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
            <br />
            Fecha:<asp:TextBox ID="TextBoxFecha" runat="server"></asp:TextBox>
            <br />
            Estado:<asp:DropDownList ID="DropDownList2" runat="server" DataTextField="Nombre" DataValueField="EstadoId">
            </asp:DropDownList>
            <br />
            Ubicacion:<asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Nombre" DataValueField="PaisId">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>
