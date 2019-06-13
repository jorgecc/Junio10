<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebListar.aspx.cs" Inherits="Junio10.WebListar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="WeatherId" HeaderText="Id Clima" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="Estado.Nombre" HeaderText="Estado" />
                    <asp:BoundField DataField="Pais.Nombre" HeaderText="Pais" />
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Estado.Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Estado.Nombre", "png/{0}.png") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
    <a href="WebInsertar.aspx">Ir a Insertar</a>
</body>
</html>
