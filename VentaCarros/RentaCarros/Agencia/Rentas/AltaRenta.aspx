<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaRenta.aspx.cs" Inherits="Agencia.Rentas.AltaRenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Alta de rentas</h3>
    <div class="container">
        <div class="row">

            <div class="row form-group">
            <label for="<%=ddlCliente.ClientID %>">Cliente:</label>
            <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control" style="width:25%">
                <asp:ListItem Value="0" Text="Selecciona Cliente"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvddlCliente" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="ddlCliente" InitialValue="0" ErrorMessage="Selecciona el cliente"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
            <label for="<%=ddlCarro.ClientID %>">Vehiculo:</label>
            <asp:DropDownList ID="ddlCarro" runat="server" CssClass="form-control" style="width:25%">
                <asp:ListItem Value="0" Text="Selecciona Vehiculo"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvddlCarro" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="ddlCarro" InitialValue="0" ErrorMessage="Selecciona el cliente"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
            <label for="<%=txtDuracion.ClientID %>">Duración en días:</label>
            <asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control" placeholder="Duracion de la renta"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtDuracion" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="txtDuracion" ErrorMessage="Duración de la renta requerida"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group" style="width:25%;">
            <label for="<%=FechaRenta.ClientID %>">Fecha y Hora de Renta:</label>
            <input id="FechaRenta" runat="server" type="text" class="form-control" /><div style="position: absolute; top: 0; left: 0;">
                <asp:RequiredFieldValidator ID="rfvtxtFechaRenta" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="FechaRenta" ErrorMessage="Fecha de renta requerida"></asp:RequiredFieldValidator>
            </div>
        </div>


        </div>
        <div class="row form-group">
            <asp:Button ID="btnGuardar" ValidationGroup="Guardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>
        </div>
    
    </div>
        <script>
        $(document).ready(function () {
            $.datetimepicker.setLocale('es');
            $("#<%=FechaRenta.ClientID %>").datetimepicker({
                format: 'm/d/Y H:i',
                minDate: '0'
            });
        });
    </script>
    
</asp:Content>
