<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaRentas.aspx.cs" Inherits="Agencia.Rentas.AltaRentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Alta de rentas</h2>
    <hr />

    <div class="container">
        <div class="row">

            <div class="row form-group">
            <label for="<%=ddlVehiculo.ClientID %>">Vehiculo:</label>
            <asp:DropDownList ID="ddlVehiculo" runat="server" CssClass="form-control" style="width:25%">
                <asp:ListItem Value="0" Text="Selecciona Vehiculo"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvddlVehiculo" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="ddlVehiculo" InitialValue="0" ErrorMessage="Selecciona el vehiculo"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
            <label for="<%=ddlCliente.ClientID %>">Cliente:</label>
            <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control" style="width:25%">
                <asp:ListItem Value="0" Text="Selecciona Cliente"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvddlCliente" ValidationGroup="Guardar" runat="server" CssClass="text-danger" ControlToValidate="ddlCliente" InitialValue="0" ErrorMessage="Selecciona el vehiculo"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
                <label for="<%=txtDuracionRenta.ClientID %>">Duración en días</label>
                <asp:TextBox ID="txtDuracionRenta" runat="server" CssClass="form-control" placeholder="10">
                </asp:TextBox>
                <div style="position:absolute;top:0;left:0;">
                    <asp:RequiredFieldValidator ID="rfvtxtDuracionRenta" ValidationGroup="Guardar" 
                        runat="server" CssClass="text-danger" ControlToValidate="txtDuracionRenta" 
                        ErrorMessage="Duración requerida"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="row form-group" style="width:25%">
            <label for="<%=FechaRenta.ClientID %>">Fecha de Renta:</label>
            <input id="FechaRenta" runat="server" type="date" class="form-control" />
                <div style="position: absolute; top: 0; left: 0">
                <asp:RequiredFieldValidator ID="rfvFechaRenta" ValidationGroup="Guardar" 
                    runat="server" CssClass="text-danger" ControlToValidate="FechaRenta" 
                    ErrorMessage="Fecha de renta requerida"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row form-group">
            <asp:Button ID="btnGuardar" ValidationGroup="Guardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>
        </div>
        </div>

    </div>
    <script>
        $(document).ready(function () {
            $.datetimepicker.setLocale('es');
            $("#<%=FechaRenta.ClientID%>").datetimepicker({
                format: 'm/d/Y H:i',
                minDate: '0'
            });
        });
    </script>
</asp:Content>
