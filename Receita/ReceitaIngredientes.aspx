<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceitaIngredientes.aspx.cs" Inherits="ReceitasWeb.Receita.ReceitaIngredientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="form-horizontal">
        <div class="form-group">
           <div class="text-center view overlay hm-white-slight" style="padding-top:30px">
            <hr />
        <h2 class="card-title">Adicione Ingredientes à sua Receita</h2>
          <hr />
          </div>  
            </div> 
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Nome" CssClass="col-md-2 control-label">Receita</asp:Label>
            <div class="col-md-4">    
            <asp:DropDownList runat="server" ID="Nome" CssClass="form-control" OnSelectedIndexChanged="Nome_SelectedIndexChanged" AutoPostBack="true">
                </asp:DropDownList>
                </div>
        </div>
           <div class="row">
            <asp:Label runat="server" AssociatedControlID="Ingrediente" CssClass="col-md-2 control-label">Ingrediente: </asp:Label>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="Ingrediente" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <asp:Label runat="server" AssociatedControlID="Quantidade" CssClass="col-md-2 control-label">Quantidade:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Quantidade" CssClass="form-control"  />
            </div>
        </div>
            <br />
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="RegistarIngredientes_Click" Text="Adicionar Ingrediente" CssClass="btn btn-warning" />
            </div>
        </div>

             <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                <asp:Label runat="server" ID="Label2" CssClass="control-label">Se o ingrediente que procura não existe na nossa listagem, introduza-o <a href="NovoIngrediente.aspx">aqui</a> e depois selecione-o na sua receita.</asp:Label>
                    </div>
                 </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                <asp:Label runat="server" ID="result" CssClass="control-label" ForeColor="White" BackColor="ForestGreen"></asp:Label>
                    </div>
                 </div>
         <div class="form-group">
         <div class="card-block">
          <h3> Lista de Ingredientes</h3>
        <asp:GridView runat="server" ID="ListagemIngredientes" CssClass="Grid" OnRowDataBound="ListagemIngredientes_RowDataBound" OnRowCommand="ListagemIngredientes_RowCommand" AutoGenerateColumns="false" >
       <HeaderStyle CssClass="GridHeader" ></HeaderStyle>
          <columns>          
            <asp:BoundField HeaderText="Ingrediente" HeaderStyle-CssClass="GridHeader" DataField="Ingrediente" ItemStyle-CssClass="GridAltItem" />
            <asp:BoundField HeaderText="Quantidades" HeaderStyle-CssClass="GridHeader" DataField="Quantidade" ItemStyle-CssClass="GridItem" />
        </columns>
        </asp:GridView>
        </div>
               </div>
            <br />
           <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClientClick="return confirm('Quer adicionar esta receita?')" OnClick="RegistarReceita_Click" Text="Adicionar Receita" CssClass="btn btn-warning" />
            </div>
        </div>
       </div>
</asp:Content>
