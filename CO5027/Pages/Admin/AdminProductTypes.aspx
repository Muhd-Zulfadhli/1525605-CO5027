<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminProductTypes.aspx.cs" Inherits="CO5027.Pages.Admin.AdminProductTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->

    <div class="table3">

    <!--This is to insert product type-->
    <p>Name:</p> 
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />

    <!--This is a button to submit-->
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />


        <br />
        <br />
        <!--This is to inform successfully inserted product type-->
        <asp:Label ID="lblResult" runat="server"></asp:Label>


    </div>
</asp:Content>
