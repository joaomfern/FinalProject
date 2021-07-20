<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoIngrediente.aspx.cs" Inherits="ReceitasWeb.Receita.NovoIngrediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <div class="form-group">
        <div class="text-center view overlay hm-white-slight" style="padding-top:30px">
            <hr />
        <h2 class="card-title">Intoduza os Novos Ingredientes para a sua Receita</h2>
             <hr />
          </div>  
            </div> 
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="NovoIngredientenome" CssClass="col-md-2 control-label">Ingrediente: </asp:Label>
            <div class="col-md-4">
                <asp:TextBox runat="server" ID="NovoIngredientenome" CssClass="form-control"  />
            </div>
            </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="NovoIngredienteDescription" CssClass="col-md-2 control-label">Descrição do Ingrediente:</asp:Label>
            <div class="col-md-4">
            <asp:TextBox runat="server" ID="NovoIngredienteDescription" TextMode="multiline" CssClass="form-control"  />
            </div>
            </div>
            
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Utilizador" CssClass="col-md-2 control-label">Ingrediente adicionado por: </asp:Label>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="Utilizador" CssClass="form-control" Enabled="False">
                </asp:DropDownList>
            </div>
            </div>

            <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClientClick="return confirm('Quer adicionar este ingrediente?')" OnClick="NovoIngrediente_Click" Text="Adicionar Novo Ingrediente" CssClass="btn btn-warning" />
            </div>
        </div>
         <div class="card-block">
          <h3>Ingredientes Existentes</h3>

        <asp:GridView runat="server" ID="ListagemIngredientes" CssClass="Grid" OnRowDataBound="ListagemIngredientes_RowDataBound" OnRowCommand="ListagemIngredientes_RowCommand" AutoGenerateColumns="false">
       <HeaderStyle CssClass="GridHeader" ></HeaderStyle>
          <columns>          
            <asp:BoundField HeaderText="Ingrediente" HeaderStyle-CssClass="GridHeader" DataField="Nome" ItemStyle-CssClass="GridAltItem" />
            <asp:BoundField HeaderText="Descrição do Ingrediente" HeaderStyle-CssClass="GridHeader" DataField="Descrição" ItemStyle-CssClass="GridItem" />
        </columns>
        </asp:GridView>
 </div>
      </div>
</asp:Content>
