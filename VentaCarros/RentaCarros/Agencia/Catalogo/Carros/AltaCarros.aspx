<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaCarros.aspx.cs" Inherits="Agencia.Catalogo.Carros.AltaCarros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class = "container">
        <div class =" row">
            <h3>Alta Vehiculos</h3>
            <hr />
            <div class="row form-group">
                <label for="<%=txtNombreCarro.ClientID %>">Nombre del Vehiculo</label>
                <asp:TextBox ID="txtNombreCarro" runat="server" CssClass="form-control" placeholder="Corvette"></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtNombreCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtNombreCarro" 
                        ErrorMessage="Nombre del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="row form-group">
                <label for="<%=txtModeloCarro.ClientID %>">Modelo del Vehiculo</label>
                <asp:TextBox ID="txtModeloCarro" runat="server" CssClass="form-control" placeholder="Hatchback"></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtModeloCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtModeloCarro" 
                        ErrorMessage="Modelo del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="row form-group">
                <label for="<%=txtMarcaCarro.ClientID %>">Marca del Vehiculo</label>
                <asp:TextBox ID="txtMarcaCarro" runat="server" CssClass="form-control" placeholder="Volkswagen "></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtMarcaCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtModeloCarro" 
                        ErrorMessage="Marca del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="row form-group">
                <label for="<%=txtMatriculaCarro.ClientID %>">Matricula del Vehiculo</label>
                <asp:TextBox ID="txtMatriculaCarro" runat="server" CssClass="form-control" placeholder="YYY-000"></asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvTxtMatriculaCarro" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtMatriculaCarro" 
                        ErrorMessage="Matricula del vehiculo requerido"></asp:RequiredFieldValidator>
                </div>

                <div style="position:absolute;top:0;left:0;">
                    <asp:RegularExpressionValidator ID="revtxtMatriculaCarro" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtMatriculaCarro"
                        ValidationExpression="^[A-Z]{3}-[0-9]{3}$"
                        ErrorMessage="El formato es incorrecto, favor de corregir"></asp:RegularExpressionValidator>
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
                <asp:Button ID="btnGuardar" validationGroup="Guardar" runat="server" Text="Guardar" CssClass="btn btn-success" Visible="false" OnClick="btnGuardar_Click" />
            </div>


        </div>
    </div>
</asp:Content>
