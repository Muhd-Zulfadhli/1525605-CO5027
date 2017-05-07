<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShopCart.aspx.cs" Inherits="CO5027.Pages.ShopCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->
    <!--This serves as a checkout page-->


    <!--This is to show the list of selected products for users before checking out-->
    <asp:Panel ID="pnlShoppingCart" runat="server">

        </asp:Panel>

    <table>

        <!--This is for total cost-->
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>
        </tr>


        <!--This is for value-added tax cost-->
        <tr>
            <td><b>Vat: </b></td>
            <td><asp:Literal ID="litVat" runat="server" Text="" /></td>
        </tr>


        <!--This is for shipping cost-->
        <tr>
            <td><b>Shipping: </b></td>
            <td>$ 5</td>
        </tr>


        <!--This is for total amount cost-->
        <tr>
            <td><b>Total Amount: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>



        <tr>
            <td>
                <!--This button is for continue shopping-->
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Products.aspx"
                    Text="Continue Shopping" />

                OR

                <!--This button is for checkout-->
                <asp:Button ID="btnCheckOut" runat="server" PostBackUrl="~/Pages/Success.aspx"
                    CssClass="button" Width="250px" Text="Checkout" />
            </td>
        </tr>
    </table>








</asp:Content>
