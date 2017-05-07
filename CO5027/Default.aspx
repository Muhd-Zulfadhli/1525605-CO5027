<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CO5027.Pages.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
  <!--Website created using tools and techniques taught in the module CO5027-->
  <!--All images from Google Images-->
  <!--CSS codes used seperately from Styles folder-->
   
   <div class="table5"></div>
   
    <!--codes for slideshow starts here-->
   
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="table2">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:AdRotator ID="AdRotator1" runat="server" width="1000px" Height="600px" AdvertisementFile="~/Slider.xml" AlternateTextField="slider" /> <!--all images came from google images-->
                <asp:Timer ID="Timer1" runat="server" Interval="2500"></asp:Timer>
            </ContentTemplate>

        </asp:UpdatePanel>

    </div>
    
    <!--codes for slideshow ends here-->
    

  

</asp:Content>
