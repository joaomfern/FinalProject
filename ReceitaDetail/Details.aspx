<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ReceitasWeb.ReceitaDetail.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container marginTop">
    <div class="row">
        <div class="card">
                <div class="text-center view overlay hm-white-slight" style="padding-top:60px">
                <asp:label runat="server" ID="Nome" class="card-title"><h1>Nome Receita</h1></asp:label>
                </div>
                <div class="text-center view overlay hm-white-slight" style="padding:30px 30px ">
                <asp:Image runat="server" ID="ImageUrl" ImageUrl="iamgem" class="img-fluid"  CssClass="receita-image"/>
                    <a href="#">
                    <div class="mask waves-effect waves-light"></div>
                </a>
                </div>
                <div class="card-block">
                <h3>Ingredientes</h3>

        <asp:GridView runat="server" ID="ListagemIngredientes" CssClass="Grid" OnRowDataBound="ListagemIngredientes_RowDataBound" OnRowCommand="ListagemIngredientes_RowCommand" AutoGenerateColumns="false">
       <HeaderStyle CssClass="GridHeader" ></HeaderStyle>
          <columns>          
            <asp:BoundField HeaderText="Ingrediente" HeaderStyle-CssClass="GridHeader" DataField="Ingrediente" ItemStyle-CssClass="GridAltItem" />
            <asp:BoundField HeaderText="Quantidades" HeaderStyle-CssClass="GridHeader" DataField="Quantidade" ItemStyle-CssClass="GridItem" />
        </columns>
        </asp:GridView>

                </div>
                <div class="card-block">
                <h3>Modo de Preparação</h3>
                <asp:label runat="server" ID="ModoPreparacao" class="card-text"><h3>Modo de Preparação</h3></asp:label>
                </div>
                <div class="card-block">
                <h3>Duração</h3>
                <asp:label runat="server" ID="Duracao" class="card-text"><h4>Duração</h4></asp:label>
                </div>
                <div class="card-block">
                <h3>Dificuldade</h3>
                <asp:label runat="server" ID="Dificuldade" class="card-text"><h4>Dificuldade</h4></asp:label>
                </div>
                <div class="card-block">
                <h3>Autor da Receita</h3>
                <asp:label runat="server" ID="Utilizador" class="card-text"><h4>Utilizador</h4></asp:label>
                </div>
                <div class="card-block">
                <h3>Categoria</h3>
                <asp:label runat="server" ID="Categoria" class="card-text"><h4>Categoria</h4></asp:label>
                </div>
            <br />
            <asp:LoginView runat="server" ViewStateMode="Disabled">
            <AnonymousTemplate>
            </AnonymousTemplate>
              <RoleGroups>
              <asp:RoleGroup Roles="Admin">
              <ContentTemplate>
            <asp:Button runat="server" ID="alterar" OnClick="Alterar_Click" Text="Alterar Receita" CssClass="btn btn-warning" />
            </div>
            <br />
                <asp:Button runat="server" ID="remover" OnClick="Remove_Click" Text="Remover Receita" CssClass="btn btn-danger"  /> 
                </div>
               </ContentTemplate>
               </asp:RoleGroup>
              </RoleGroups>
        </asp:LoginView>
</asp:Content>
