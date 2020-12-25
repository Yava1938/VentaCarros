<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="Agencia.Catalogo.Clientes.ListaPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .foto {
            padding: 5px;
        }
    </style>
    <div class="container">
        <div class="row" style="margin-bottom: 18px">
            <h3>Lista Cliente</h3>
            <hr />
        </div>
        <div class="row col-md-10 col-md-offset-1">
            <asp:GridView ID="gvClientes"
                runat="server" AutoGenerateColumns="false"
                DataKeyNames="IdCliente" 
                OnRowCommand="gvClientes_RowCommand">
                <Columns>
                    <asp:ImageField HeaderText="Foto" ReadOnly="true" DataImageUrlField="UrlFoto" ControlStyle-Width="110px" ControlStyle-Height="120px" ControlStyle-CssClass="fotogv"></asp:ImageField>
                    <asp:BoundField HeaderText="Id" ItemStyle-Width="50px" DataField="IdCliente" ReadOnly="true" />
                    <asp:BoundField HeaderText="Nombre" ItemStyle-Width="150px" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido paterno" ItemStyle-Width="150px" DataField="Apellido_paterno" />
                    <asp:BoundField HeaderText="Apellido materno" ItemStyle-Width="150px" DataField="Apellido_materno" />
                    <asp:BoundField HeaderText="Correo" ItemStyle-Width="150px" DataField="Correo" />
                    <asp:BoundField HeaderText="Telefono" ItemStyle-Width="150px" DataField="Telefono" />
                    <asp:BoundField HeaderText="Direccion" ItemStyle-Width="150px" DataField="Direccion" />
  
                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-success btn-xs" Text="Seleccionar" CommandName="Select" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
