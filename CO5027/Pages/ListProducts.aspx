<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="CO5027.Pages.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->
    <!--This serves as a product's individual page-->

    <br />

    <!--Table shows a product's image, description and price-->
    <table>
        <tr>
    <td rowspan="4"><asp:Image ID="imgProduct" runat="server" /></td>
    <td>
        <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></td>
    </tr>

        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server"></asp:Label></td></tr>
           <tr> <td>
                <asp:Label ID="lblPrice" runat="server"></asp:Label></td>

            
            <!--This is to choose the quantity-->
            <td>Quantity :
            <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />


            <!--This button is to add selected product into shopping cart-->
            <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="button" OnClick="btnAdd_Click" /><br />

            <!--This is to inform user of successfully inserted product-->
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
        </tr>


        <!--This is to show product's number-->
        <tr>
            <td>Product Number: <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label></td>

        </tr>     
        </table>


    <br />
</asp:Content>
