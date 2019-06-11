<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInsertarPais.aspx.cs" Inherits="Junio10.WebFormInsertarPais" %>

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
            Nombre:<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
    </form>
   
</body>
</html>
