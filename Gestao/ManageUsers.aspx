<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="ReceitasWeb.Gestao.ManageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron text-center ">
        <h1 class="card-title">Utilizadores</h1>
            <asp:GridView runat="server" ID="Listagem" CssClass="Grid" OnRowDataBound="Listagem_RowDataBound" OnRowCommand="Listagem_RowCommand" AutoGenerateColumns="false" >
       <HeaderStyle CssClass="GridHeader" ></HeaderStyle>
          <columns>
            <asp:BoundField HeaderText="Nome" HeaderStyle-CssClass="GridHeader" DataField="username" ItemStyle-CssClass="GridAltItem" />
            <asp:BoundField HeaderText="Email" HeaderStyle-CssClass="GridHeader" DataField="Email" ItemStyle-CssClass="GridAltItem" />
                          <asp:TemplateField HeaderText="Alterar Utilizador" HeaderStyle-CssClass="GridHeader" ItemStyle-CssClass="GridItem">
                <ItemTemplate>
                    <asp:LinkButton ID="lb1" runat="server" Text=Alterar CommandName="NameButtonAlterar" CommandArgument='<%# Eval("Id") %>' />
                </ItemTemplate>
                               </asp:TemplateField>
              <asp:TemplateField HeaderText="Eliminar Utilizador" HeaderStyle-CssClass="GridHeader" ItemStyle-CssClass="GridItem">
                <ItemTemplate>
                    <asp:LinkButton ID="lb2" runat="server" Text=Eliminar CommandName="NameButtonEliminar" CommandArgument='<%# Eval("Id") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </columns>
        </asp:GridView>
    </div>
</asp:Content>
