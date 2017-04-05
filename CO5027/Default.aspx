<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CO5027.Pages.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>&nbsp;</p>


    <p>Welcome to meTV</p>
    
    <p>&nbsp;</p>
    <p>&nbsp;</p>

    <!--codes for slideshow starts here-->
   
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="table2">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:AdRotator ID="AdRotator1" runat="server" width="1000px" Height="400px" AdvertisementFile="~/Slider.xml" /> <!--all images came from google images-->
                <asp:Timer ID="Timer1" runat="server" Interval="2500"></asp:Timer>
            </ContentTemplate>

        </asp:UpdatePanel>

    </div>

    <!--codes for slideshow ends here-->


    <p>&nbsp;</p>
    <p>&nbsp;</p>

</asp:Content>
