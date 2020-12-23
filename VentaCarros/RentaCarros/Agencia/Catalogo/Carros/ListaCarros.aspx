<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCarros.aspx.cs" Inherits="Agencia.Catalogo.Carros.ListaCarros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        .fotogv{
            padding:5px;
        }
    </style>
    <div class="container">
        <div class="row" style="margin-bottom:18px">
            <h3>Lista de vehiculos</h3>
            <hr>
            </div>
        <div class="row-md-10 col-md-offset-1">
            <asp:GridView ID="gvCarros" runat="server" AutoGenerateColumns="false"
                DataKeyNames="IdCarro" OnRowCommand="gvCarros_RowCommand">
                <Columns>
                    <asp:ImageField HeaderText="Foto" ReadOnly="true" DataImageUrlField="UrlFoto" ControlStyle-Width="110px" ControlStyle-CssClass="fotogv"></asp:ImageField>
                    <asp:BoundField HeaderText="Id" ItemStyle-Width="50px" DataField="IdCarro" ReadOnly="true" />
                    <asp:BoundField HeaderText="Nombre" ItemStyle-Width="150px" DataField="Nombre" ReadOnly="true" />
                    <asp:BoundField HeaderText="Modelo" ItemStyle-Width="150px" DataField="Modelo" ReadOnly="true" />
                    <asp:BoundField HeaderText="Marca" ItemStyle-Width="150px" DataField="Marca" ReadOnly="true" />
                    <asp:BoundField HeaderText="Matricula" ItemStyle-Width="150px" DataField="Matricula" ReadOnly="true" />
                    <asp:BoundField HeaderText="Año" ItemStyle-Width="50px" DataField="Anio" ReadOnly="true" />
                    <asp:BoundField HeaderText="Precio" ItemStyle-Width="50px" DataField="Precio" ReadOnly="true" />
                    <asp:TemplateField HeaderText="Disponible" ItemStyle-Width="50px" >
                        <ItemTemplate>
                            <div style="width:100%">
                                <div style="width: 25%; margin: 0 auto">
                                    <asp:CheckBox ID="chkDisponible" runat="server" Enabled="false" Checked='<%#Eval("Disponibilidad") %>'/>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-success btn-xs" Text="Seleccionar" CommandName="Select" />
                </Columns>
            </asp:GridView>
        </div>

    </div>



</asp:Content>
