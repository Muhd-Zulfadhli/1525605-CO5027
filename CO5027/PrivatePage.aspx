<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PrivatePage.aspx.cs" Inherits="CO5027.PrivatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    
    You are now in a protected page via successful log in. <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btnLogOut_Click" />

    <br />
    <br />
    <br />
    <br />

</asp:Content>
