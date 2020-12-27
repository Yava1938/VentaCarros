<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="Agencia.Catalogo.Clientes.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Editar cliente</h3>
            <h4>ID: 
                <asp:Label ID ="lblIdCliente" runat="server" Text=""></asp:Label>
            </h4>
            <hr />
        </div>

        <div class="row form-group">
            <label for="<%=txtNombre.ClientID %>">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtNombre" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtNombre" ErrorMessage="Nombre de la persona requerido"></asp:RequiredFieldValidator>
        </div>

        <div class="row form-group">
            <label for="<%=txtApellido_paterno.ClientID %>">Apellido paterno:</label>
            <asp:TextBox ID="txtApellido_paterno" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtApellido_paterno" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtApellido_paterno" ErrorMessage="Apellido paterno de la persona requerido"></asp:RequiredFieldValidator>
        </div>

        <div class="row form-group">
            <label for="<%=txtApellido_materno.ClientID %>">Apellido materno:</label>
            <asp:TextBox ID="txtApellido_materno" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtApellido_materno" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtApellido_materno" ErrorMessage="Apellido materno de la persona requerido"></asp:RequiredFieldValidator>
        </div>

        <div class="row form-group">
            <label for="<%=txtCorreo.ClientID %>">Correo:</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="nombre@host.com"></asp:TextBox>
            <div class="col-md-12" style="margin-bottom: 20px;">
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RequiredFieldValidator ID="rfvtxtCorreo" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtCorreo" ErrorMessage="Correo de la persona requerido"></asp:RequiredFieldValidator>
                </div>
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RegularExpressionValidator ID="revtxtCorreo" runat="server" CssClass="text-danger" ControlToValidate="txtCorreo" ValidationExpression="^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$" ErrorMessage="El formato de correo es nombre@host.com"></asp:RegularExpressionValidator>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <label for="<%=txtTelefono.ClientID %>">Teléfono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="(000) 000-0000"></asp:TextBox>
            <div class="col-md-12" style="margin-bottom: 20px;">
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RequiredFieldValidator ID="rfvtxtTelefono" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtTelefono" ErrorMessage="Teléfono de la persona requerido"></asp:RequiredFieldValidator>
                </div>
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RegularExpressionValidator ID="revtxtTelefono" runat="server" CssClass="text-danger" ControlToValidate="txtTelefono" ValidationExpression="^\(\d{3}\) \d{3}-\d{4}$" ErrorMessage="El formato de teléfono es (000) 000-0000"></asp:RegularExpressionValidator>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <label for="<%=txtDireccion.ClientID %>">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Calle #. Colonia. CP"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtDireccion" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtDireccion" ErrorMessage="Dirección de la persona requerida"></asp:RequiredFieldValidator>
        </div>

        <div class="row form-inline">
            <div class="colo-md-12">
                <label>Selecciona Foto:</label>
                <input type="file" class="btn btn-default btn-file" runat="server" id="SubeImagen" style="display: inline-block;" />
                <asp:Button ID="btnSubeImagen" runat="server" Text="Subir Imagen" CssClass="btn btn-primary btn-xs" OnClick="btnSubeImagen_Click" />
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-3" style="text-align: center;">
                <label for="<%=lblUrlFoto.ClientID %>">Foto:</label>
                <asp:Image ID="imgFotoPersona" Width="200" Height="200" runat="server" />
                <label id="lblUrlFoto" runat="server"></label>
            </div>
        </div>

        <div class="row form-group">
                <asp:Button ID="btnGuardar" validationGroup="Guardar" runat="server" Text="Guardar" 
                    CssClass="btn btn-success" Visible="false" OnClick="btnGuardar_Click" />

                <asp:Button ID="btnEliminar" validationGroup="Guardar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
            </div>
            <div class="col-md-2">

            </div>
    </div>

</asp:Content>
