<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CO5027.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">









    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    <br />
    <br />
    

    Username:<br />
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    

    









Password:<br />
<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
<br />
<br />
<br />
<asp:Button ID="btnLogIn" runat="server" CssClass="button" OnClick="btnLogIn_Click" Text="Log In" />
    

    









</asp:Content>
