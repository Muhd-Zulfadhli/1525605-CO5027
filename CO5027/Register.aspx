<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CO5027.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <ul>
          <li><asp:Label ID="nameLabel" runat="server" Text="Username:"></asp:Label></li>
          <li><asp:TextBox ID="txtLoginEmail" runat="server"></asp:TextBox></li>
          <li><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Name" ControlToValidate="usernametxtbox"></asp:RequiredFieldValidator></li>
          </ul>

         <ul>
          <li><asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label></li>
          <li><asp:TextBox ID="txtLoginPassword" runat="server"></asp:TextBox></li>
          <li><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Password" ControlToValidate="passwordtxtbox"></asp:RequiredFieldValidator></li>
          </ul>

    <br />
        
   <ul>
     <li><asp:Button ID="registerbtn_click" runat="server" Text="Register" OnClick="btnReg_Click" /></li>
    </ul>

    <ul>
          <li><asp:Label ID="litLoginError" runat="server"></asp:Label></li>
</ul>



</asp:Content>
