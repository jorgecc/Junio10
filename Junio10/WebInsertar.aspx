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
            Estado:<asp:TextBox ID="TextBoxEstado" runat="server"></asp:TextBox>
            <br />
            Ubicacion:<asp:TextBox ID="TextBoxUbicacion" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>
