<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CO5027.Pages.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


   <p>&nbsp;</p>



      
       <p>Contact Us</p>

     <p>&nbsp;</p>


      <!--codes for contact form starts here-->
      <fieldset>
          <legend>Info</legend>
      <div class="table">

        <p>&nbsp;</p>

      <div id="contactinfoname">

          
          <ul>
          <li><asp:Label ID="nameLabel" runat="server" Text="Name:"></asp:Label></li>
          <li><asp:TextBox ID="nametxtbox" runat="server"></asp:TextBox></li>
          <li><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Name" ControlToValidate="nametxtbox"></asp:RequiredFieldValidator></li>
          </ul>

      </div>
          
          <p>&nbsp;</p>


       <div id="contactinfoemail">
          <ul>
          <li><asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label></li>
          <li><asp:TextBox ID="emailtxtbox" runat="server"></asp:TextBox></li>
          <li><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="emailtxtbox"></asp:RegularExpressionValidator></li>
           </ul>
      </div>

          <p>&nbsp;</p>


      <div id="contactinfotopic">
<ul>
          <li><asp:Label ID="topicLabel" runat="server" Text="Topic:"></asp:Label></li>
          <li><asp:TextBox ID="topictxtbox" runat="server"></asp:TextBox></li>
          <li><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Topic" ControlToValidate="topictxtbox"></asp:RequiredFieldValidator></li>
</ul>      </div>

          <p>&nbsp;</p>



      <div id="contactinfomessage">
          <ul>
          <li><asp:Label ID="messageLabel" runat="server" Text="Message:"></asp:Label></li>
          <li><asp:TextBox ID="messagetextbox" runat="server" TextMode="MultiLine" ></asp:TextBox></li>
          <li><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Message" ControlToValidate="messagetextbox"></asp:RequiredFieldValidator></li>
          </ul>
      </div>

         <p>&nbsp;</p>


      <div id="submitbtn">
<ul>
          <li><asp:Button ID="submitbtn_click" runat="server" Text="Submit Message" OnClick="submitbtn_click_Click" /></li>
</ul>     

      </div>

    

      <div id="resultarea">
<ul>
          <li><asp:Label ID="litResult" runat="server"></asp:Label></li>
</ul>      

      </div>
      </div>

        </fieldset>      

    <!--codes for contact form ends here-->


    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>

       <p>Google Map</p>
    <p>&nbsp;</p>


  
          
    <!--div class and id codes moved to css--> 
        <div class="table2"><input type="text" id="mapsearch" size="50" ></div>
          <div id="map-canvas"></div>
          


    <!--script for google map starts here-->
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAJocihmXXsvBzyoEZAnM7xKatanVSWMXg&libraries=places"></script>

          <script>

              var map = new google.maps.Map(document.getElementById('map-canvas'), {
                  center: {
                      lat: 4.8863,
                      lng: 114.9324
                  },
                  zoom: 15
              });

              var marker = new google.maps.Marker({
                  position: {
                      lat: 4.8863,
                      lng: 114.9324

                  },
                  map: map,
                  draggable: true
              });

              var searchBox = new google.maps.places.SearchBox(document.getElementById('mapsearch'));

              // this is to change event on search box
              google.maps.event.addListener(searchBox, 'places_changed', function () {

                  // this codes for console.log(searchBox.getPlaces())
                  var places = searchBox.getPlaces();


                  //bound
                  var bounds = new google.maps.LatLngBounds();
                  var i, place;


                  for (i = 0; place = places[i]; i++) {


                      // this codes for console.log(place.geometry.location)

                      bounds.extend(place.geometry.location);
                      marker.setPosition(place.geometry.location);

                  }


                  map.fitBounds(bounds); // this is fit to the bound
                  map.setZoom(15); // this is for set zoom

              });

          </script>
          
    <!--script for google map ends here--> 

    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>

    

    

     
</asp:Content>
