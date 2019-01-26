<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Admin_Produtos_Cadastrar" MasterPageFile="~/Admin/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="head">

  
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID ="body">

   Nome da fruta <asp:TextBox runat="server" ID="txtNomefruta" />
    <asp:Button Text="Cadatrar" runat="server" ID="btnCadastrar" OnClick="btnCadastrar_Click"/>

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="footer">


</asp:Content>