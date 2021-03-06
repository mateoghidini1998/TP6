<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_GRUPO4.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Productos<br />
            </strong>
            <div class="auto-style2">
                <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" OnPageIndexChanging="grdProductos_PageIndexChanging1" OnRowDeleting="grdProductos_RowDeleting" AutoGenerateEditButton="True" OnRowCancelingEdit="grdProductos_RowCancelingEdit" OnRowEditing="grdProductos_RowEditing" OnRowUpdating="grdProductos_RowUpdating">
                    <Columns>
                        <asp:TemplateField HeaderText="Id Producto">
                            <EditItemTemplate>
                                <asp:Label ID="lbl_eit_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre Producto">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_eit_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad por Unidad">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_eit_CantidadPorUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_it_CantidadxUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_eit_Precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_it_Precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <strong>
            <br />
            <asp:Label ID="lblMensajeNombre" runat="server" ForeColor="#993300"></asp:Label>
            <br />
            <asp:Label ID="lblMensajeCantidad" runat="server" ForeColor="#993300"></asp:Label>
            <br />
            <asp:Label ID="lblMensajePrecio" runat="server" ForeColor="#993300"></asp:Label>
            <br />
            </strong>
        </div>
    </form>
</body>
</html>
