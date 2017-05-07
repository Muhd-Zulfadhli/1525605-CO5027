<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CO5027.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->

    <!--This is to inform user of incorrect username or password-->
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    <br />
    <br />
    

    <!--This is for entering username-->
    Username:<br />
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    

    <!--This is for entering password-->
    Password:<br />
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <br />


    <!--This a button to log in-->
    <asp:Button ID="btnLogIn" runat="server" CssClass="button" OnClick="btnLogIn_Click" Text="Log In" />
    

    









</asp:Content>
