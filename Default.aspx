<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReceitasWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center ">
        <h1 class="card-title">Lista de Receitas</h1>
        <h3>Descubra as receitas mais deliciosas no nosso site</h3>
        <div style="padding-left:150px;padding-top:30px;"
        <asp:GridView runat="server" ID="Listagem" CssClass="Grid" OnRowDataBound="Listagem_RowDataBound" OnRowCommand="Listagem_RowCommand" AutoGenerateColumns="false">
       <HeaderStyle CssClass="GridHeader" ></HeaderStyle>
          <columns>
            <asp:TemplateField HeaderText="Nome da Receita" HeaderStyle-CssClass="GridHeader" ItemStyle-CssClass="GridItem">
                <ItemTemplate>
                    <asp:LinkButton ID="lb1" runat="server" Text='<%# Eval("Nome da Receita") %>' CommandName="NameButton" CommandArgument='<%# Eval("ReceitaID") %>' />
                </ItemTemplate>
            </asp:TemplateField> 
            <asp:BoundField HeaderText="Duração (em Minutos)" HeaderStyle-CssClass="GridHeader" DataField="Duração (em Minutos)" ItemStyle-CssClass="GridItem" />
            <asp:BoundField HeaderText="Dificuldade" HeaderStyle-CssClass="GridHeader" DataField="Dificuldade" ItemStyle-CssClass="GridAltItem"  />
            <asp:BoundField HeaderText="Autor da Receita" HeaderStyle-CssClass="GridHeader" DataField="Autor da Receita" ItemStyle-CssClass="GridItem" />
            <asp:BoundField HeaderText="Categoria" HeaderStyle-CssClass="GridHeader" DataField="Categoria"  ItemStyle-CssClass="GridAltItem" />
        </columns>
        </asp:GridView>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Partilhe Novas Receitas</h2>
            <p>
               Adicione novas receitas deliciosas e partilhe com a nossa comunidade.
            </p>
            <p style="padding-top:55px">
            <asp:Image runat="server" ImageUrl="../Imagens/bacalhau-bras-com-legumes.jpg" CssClass="HomeImage" />
            </p>
            <p>
                <a class="btn btn-primary" href="Receita/Receita">Saiba mais &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" >
            <h2>Escolha os seus Ingredientes Favoritos</h2>
            <p>
                Crie a sua receita e adicione os seus ingredientes favoritos
            </p>
            <p style="padding-top:40px">
            <asp:Image runat="server" ImageUrl="../Imagens/ingredientes.jpg" CssClass="HomeImage" />
            </p>
            <p >
                <a class="btn btn-primary" href="Receita/ReceitaIngredientes">Saiba mais &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Adicione Ingredientes Únicos</h2>
            <p>
                O ingrediente que procura não existe? Adicione o seu ingrediente para que toda a comunidade o possa utilizar!
            </p>
            <p style="padding-top:20px">
            <asp:Image runat="server" ImageUrl="../Imagens/novosingredientes.jpg" CssClass="HomeImage" />
            </p>
            <p>
                <a class="btn btn-primary" href="Receita/NovoIngrediente">Saiba mais &raquo;</a>
            </p>
        </div>
    </div>
    </div>
</asp:Content>
