<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="CO5027.Pages.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
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
            <td>Quantity :
            <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="button" OnClick="btnAdd_Click" /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
        </tr>


        <tr>
            <td>Product Number: <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label></td>

        </tr>

        















    </table>
    <br />
</asp:Content>
