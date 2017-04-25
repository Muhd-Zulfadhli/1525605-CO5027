<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminProducts.aspx.cs" Inherits="CO5027.Pages.Admin.AdminProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table3">
    <p>Name:</p> 
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />


    <p>Type:</p>
        <p>
            <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:meTVConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
        </p>
        <br />

        <p>Price:</p>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
       

        <p>Image:</p>
        <asp:DropDownList ID="ddlImage" runat="server">
        </asp:DropDownList>
        <br />
        
        <p>Description:</p>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>



        </div>

</asp:Content>
