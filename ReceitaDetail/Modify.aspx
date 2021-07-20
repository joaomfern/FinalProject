<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="ReceitasWeb.ReceitaDetail.Modify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="form-horizontal">
        <div class="form-group">
        <div class="text-center view overlay hm-white-slight" style="padding-top:30px">
            <hr />
        <h2 class="card-title">Modifique sua Receita!</h2>
             <hr />
          </div>  
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Nome" CssClass="col-md-2 control-label">Nome da Receita: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Nome" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nome"
                    CssClass="text-danger" ErrorMessage="The description field is required." />
            </div>
        </div>
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Preparacao" CssClass="col-md-2 control-label">Modo de Preparação</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" TextMode="multiline" ID="Preparacao" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Preparacao"
                    CssClass="text-danger" ErrorMessage="The description field is required." />
            </div>
        </div>
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Duracao" CssClass="col-md-2 control-label">Duração (em minutos)</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Duracao" CssClass="form-control" />
                  <asp:RequiredFieldValidator runat="server" ControlToValidate="Duracao"
                    CssClass="text-danger" ErrorMessage="The description field is required." />
            </div>
            </div>
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Dificuldade" CssClass="col-md-2 control-label">Dificuldade</asp:Label>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="Dificuldade" CssClass="form-control">
                  <asp:ListItem Text="Fácil" />
                  <asp:ListItem Text="Médio" />
                  <asp:ListItem Text="Dificil"/>
                </asp:DropDownList>
            </div>
        </div>
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Utilizador" CssClass="col-md-2 control-label">Autor da Receita: </asp:Label>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="Utilizador" CssClass="form-control">
                </asp:DropDownList>
            </div>
        </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Categoria" CssClass="col-md-2 control-label">Categoria</asp:Label>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="Categoria" CssClass="form-control">
                </asp:DropDownList>
            </div>
        </div>
            
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Imagem" CssClass="col-md-2 control-label">Fotografia da Receita</asp:Label>
            <div class="col-md-4">
        <asp:FileUpload runat="server"  ID="Imagem" Text="Procurar.." />
                </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="Modificar_Click" Text="Modificar" CssClass="btn btn-warning" />
            </div>
        </div>
       </div>
</asp:Content>
