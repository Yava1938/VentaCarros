<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnRenta.aspx.cs" Inherits="Agencia.Rentas.EnRenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>En Renta</h3>
    <hr />
    <div class="container">
        <div class="row">
            <div class="row-md-10 col-md-offset-1">
            <asp:GridView ID="gvRentas" runat="server" AutoGenerateColumns="false"
                DataKeyNames="IdRenta"  OnRowCommand="gvRentas_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="Id" ItemStyle-Width="50px" DataField="IdRenta" ReadOnly="true" />
                    <asp:BoundField HeaderText="Carro" ItemStyle-Width="150px" DataField="IdCarro" ReadOnly="true" />
                    <asp:BoundField HeaderText="Cliente" ItemStyle-Width="150px" DataField="IdCliente" ReadOnly="true" />
                    <asp:BoundField HeaderText="Duracion" ItemStyle-Width="150px" DataField="Duracion" ReadOnly="true" />
                    <asp:BoundField HeaderText="Fecha" ItemStyle-Width="160px" DataField="Fecha" ReadOnly="true" />
                    <asp:BoundField HeaderText="Estado" ItemStyle-Width="50px" DataField="Estado" ReadOnly="true" />
                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-success btn-xs" Text="Finalizar" CommandName="Select" />
                </Columns>
            </asp:GridView>
        </div>
        </div>
    </div>
</asp:Content>
