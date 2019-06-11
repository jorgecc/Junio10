<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebListar.aspx.cs" Inherits="Junio10.WebListar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
    <a href="WebInsertar.aspx">Ir a Insertar</a>
</body>
</html>
