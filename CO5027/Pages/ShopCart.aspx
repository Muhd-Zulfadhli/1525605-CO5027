<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShopCart.aspx.cs" Inherits="CO5027.Pages.ShopCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlShoppingCart" runat="server">

        </asp:Panel>

    <table>
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td><b>Vat: </b></td>
            <td><asp:Literal ID="litVat" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td><b>Shipping: </b></td>
            <td>$ 5</td>
        </tr>

        <tr>
            <td><b>Total Amount: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Products.aspx"
                    Text="Continue Shopping" />

                OR
                <asp:Button ID="btnCheckOut" runat="server" PostBackUrl="~/Pages/Success.aspx"
                    CssClass="button" Width="250px" Text="Checkout" />
            </td>
        </tr>
    </table>








</asp:Content>
