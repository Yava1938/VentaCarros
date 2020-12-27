<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCarro.aspx.cs" Inherits="Agencia.Catalogo.Carros.EditarCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h3>Confirmar que los datos que se van a introducir sean correctos!</h3>
        <div class="row">
            <h3>Edición Vehiculos</h3>
            <h4>ID:
                <asp:Label ID="lblCarro" runat="server"></asp:Label></h4>
            <hr />
        </div>

        <div class="row form-group">
            <label for="<%=txtNombreCarro.ClientID %>">Nombre:</label>
            <asp:TextBox ID="txtNombreCarro" runat="server" CssClass="form-control" placeholder="Corvete"></asp:TextBox>
            <div class="col-md-12" style="margin-bottom: 20px;">
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RequiredFieldValidator ID="rfvtxtNombreCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtNombreCarro" 
                        ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <label for="<%=txtModeloCarro.ClientID %>">Modelo:</label>
            <asp:TextBox ID="txtModeloCarro" runat="server" CssClass="form-control" placeholder="HashBack"></asp:TextBox>
            <div class="col-md-12" style="margin-bottom: 20px;">
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RequiredFieldValidator ID="rfvtxtModeloCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtModeloCarro" 
                        ErrorMessage="Modelo requerido"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <label for="<%=txtMarcaCarro.ClientID %>">Marca:</label>
            <asp:TextBox ID="txtMarcaCarro" runat="server" CssClass="form-control" placeholder="Chevrolet"></asp:TextBox>
            <div class="col-md-12" style="margin-bottom: 20px;">
                <div style="position: absolute; top: 0; left: 0">
                    <asp:RequiredFieldValidator ID="rfvtxtMarcaCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtMarcaCarro" 
                        ErrorMessage="Marca requerido"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <label for="<%=txtMatriculaCarro.ClientID %>">Matrícula:</label>
            <asp:TextBox ID="txtMatriculaCarro" runat="server" CssClass="form-control" placeholder="YYY-000"></asp:TextBox>
            <div style="position: absolute; top: 0; left: 0">
                <asp:RequiredFieldValidator ID="rfvtxtMatriculaCarro" ValidationGroup="Guardar" runat="server" 
                    CssClass="text-danger" ControlToValidate="txtMatriculaCarro" ErrorMessage="Matrícula requerida">
                </asp:RequiredFieldValidator>
            </div>
            <div style="position: absolute; top: 0; left: 0">
                <asp:RegularExpressionValidator ID="revtxtMatricula" runat="server" CssClass="text-danger" 
                    ControlToValidate="txtMatriculaCarro" ValidationExpression="^[A-Z]{3}-[0-9]{3}$" 
                    ErrorMessage="El formato de matrícula es XXX-000 (Mayúsculas)"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="row form-group">
                <label for="<%=txtAnioCarro.ClientID %>">Año del Vehiculo</label>
                <asp:TextBox ID="txtAnioCarro" runat="server" CssClass="form-control" placeholder="2015"></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtAnioCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtAnioCarro" 
                        ErrorMessage="Año del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>

                <div style="position:absolute;top:0;left:0;">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtMatriculaCarro"
                        ValidationExpression="^[0-9]{4}$"
                        ErrorMessage="El formato es incorrecto, favor de corregir"></asp:RegularExpressionValidator>
                </div>

            </div>

            <div class="row form-group">
                <label for="<%=txtPrecioCarro.ClientID %>">Precio por día del Vehiculo</label>
                <asp:TextBox ID="txtPrecioCarro" runat="server" CssClass="form-control" placeholder="00.00"></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtPrecioCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtPrecioCarro" 
                        ErrorMessage="Precio del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>

                <div style="position:absolute;top:0;left:0;">
                    <asp:RegularExpressionValidator ID="revTxtPrecioCarro" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtPrecioCarro"
                        ValidationExpression="^[0-9]+(\.[0-9][0-9]?)?$"
                        ErrorMessage="El formato es incorrecto, favor de corregir"></asp:RegularExpressionValidator>
                </div>

            </div>

            <div class="row form-inline">
                <div class="col-md-12">
                    <label>Selecciona foto:</label>
                    <input type="file" class="btn btn-default btn-file" runat="server" id="SubeImagen" style="display:inline-block;" />
                    <asp:Button ID="btnSubeImagen" runat="server" Text="Subir imagen" CssClass="btn btn-primary btn-xs" OnClick="btnSubeImagen_Click" />
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3" style="text-align:center;">
                    <label for="<%=SubeImagen.ClientID %>">Foto</label>
                    <asp:Image ID="imgFotoCarro" Width="200" Height="200" runat="server" />
                    <label id="lblUrlFoto" runat="server"></label>
                </div>
            </div>

            <div class="row form-group">
                <asp:Button ID="btnGuardar" validationGroup="Guardar" runat="server" Text="Guardar" 
                    CssClass="btn btn-success" Visible="false" OnClick="btnGuardar_Click" />

                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" 
                    CssClass="btn btn-danger"  OnClick="btnEliminar_Click" />       
            </div>
            
    </div>
</asp:Content>