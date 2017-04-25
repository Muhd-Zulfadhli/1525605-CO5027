<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminProductTypes.aspx.cs" Inherits="CO5027.Pages.Admin.AdminProductTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table3">
    <p>Name:</p> 
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />














        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>














    </div>
</asp:Content>
