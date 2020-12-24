<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCliente.aspx.cs" Inherits="Agencia.Catalogo.Clientes.DetalleCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <h3>Detalle Clientes</h3>
            <h4>ID:
                <asp:Label ID="lblIdCliente" runat="server" Text=""></asp:Label></h4>
            <hr />
        </div>
    <div class = "col-md-10 col-md-offset-1">
        <dl class ="dl-horizontal">
            
            <dt><label for="<%=lblNombre.ClientID%>">Nombre:</label></dt>
            <dd><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=lblApellido_paterno.ClientID%>">Apellido Paterno:</label></dt>
            <dd><asp:Label ID="lblApellido_paterno" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=lblApellido_materno.ClientID%>">Apellido materno:</label></dt>
            <dd><asp:Label ID="lblApellido_materno" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=lblCorreo.ClientID%>">Correo:</label></dt>
            <dd><asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=lblTelefono.ClientID%>">Telefono:</label></dt>
            <dd><asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=lblDireccion.ClientID%>">Direccion:</label></dt>
            <dd><asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label></dd>

            <dt><label for="<%=imgFotoPersona %>">Foto:</label></dt>
            <dd><asp:Image ID="imgFotoPersona" Width="200" Height="200" runat="server" /></dd>

        </dl>

        <div class="row" style="margin-bottom: 18px">
                <h3>Lista Carros</h3>
                <hr/>
        </div>

        <div class="row col-md-10 col-md-offset-2">
                <asp:GridView ID="gvCarros" runat ="server" AutoGenerateColumns="false" DataKeyNames="IdCarro">
                    <Columns>
                        <asp:ImageField HeaderText="Foto" ReadOnly="true" DataImageUrlField="UrlFoto" ControlStyle-Width="100px" ControlStyle-CssClass="fotogv"></asp:ImageField>
                        <asp:BoundField HeaderText="Id" ItemStyle-Width="50px" DataField="IdCarro" ReadOnly="true" />
                        <asp:BoundField HeaderText="Nombre" ItemStyle-Width="50px" DataField="Nombre" ReadOnly="true" />
                        <asp:BoundField HeaderText="Modelo" ItemStyle-Width="50px" DataField="Modelo" ReadOnly="true" />
                        <asp:BoundField HeaderText="Marca" ItemStyle-Width="50px" DataField="Marca" ReadOnly="true" />
                        <asp:BoundField HeaderText="Matricula" ItemStyle-Width="50px" DataField="Matricula" ReadOnly="true" />
                        <asp:BoundField HeaderText="Anio" ItemStyle-Width="50px" DataField="Anio" ReadOnly="true" />
                        <asp:BoundField HeaderText="Precio" ItemStyle-Width="50px" DataField="Precio" ReadOnly="true" />
                        <asp:TemplateField HeaderText="Disponibilidad" ItemStyle-Width="50px" DataField="Disponibilidad" ReadOnly="true">
                            <ItemTemplate>
                                <div style="width: 100%">
                                    <div style="width: 25%; margin: 0 auto">
                                        <asp:CheckBox ID="chkDisponible" runat="server" Enabled="false" Checked='<%#Eval ("Disponibilidad") %>' />
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </div>
    </div>
    <div class="row form-group col-md-10 col-md-offset-4" style="padding-top:20px">
            <div class="col-md-4">
                <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-success" OnClick="btnEditar_Click" />
            </div>
            <div class="col-md-4">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
            </div>
    </div>
</asp:Content>
