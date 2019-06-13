<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebInsertar.aspx.cs" Inherits="Junio10.WebInsertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
