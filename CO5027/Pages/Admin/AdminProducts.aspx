<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminProducts.aspx.cs" Inherits="CO5027.Pages.Admin.AdminProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Website created using tools and techniques taught in the module CO5027-->
    <!--All images from Google Images-->
    <!--CSS codes used seperately from Styles folder-->


        <div class="table3">

        <!--This is to insert product name-->
        <p>Name:</p> 
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />


        <!--This is to insert product type-->
        <p>Type:</p>
        <p>
            <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:meTVConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
        </p>
        <br />


        <!--This is to insert product price-->
        <p>Price:</p>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
       
        
        <!--This is to insert product image-->
        <p>Image:</p>
        <asp:DropDownList ID="ddlImage" runat="server">
        </asp:DropDownList>
        <br />
        

        <!--This is to insert product description-->
        <p>Description:</p>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>


        <!--This is to submit the product to Products.aspx page-->
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>


        <!--This is to inform successfully inserted product-->
        <p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>



        </div>

</asp:Content>
