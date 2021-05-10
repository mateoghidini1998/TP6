<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Productos:<br />
            <asp:GridView ID="grdProductos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdProductos_SelectedIndexChanged" AutoGenerateColumns="False" AutoGenerateSelectButton="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="IdProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NombreProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IdProveedor">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PrecioUnidad">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <br />
            <asp:Label ID="lblAgregado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
