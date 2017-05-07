<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CO5027.Pages.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->

    <!--This is to inform user of incorrect username or password-->
    <asp:Literal ID="LitStatus" runat="server"></asp:Literal>
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


    <!--This is for entering confirmed password-->
    Confirm Password:<br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    &nbsp;<br />
    <br />
    <br />


    <!--This is a button to register-->
    <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Register" />
    &nbsp;





</asp:Content>
