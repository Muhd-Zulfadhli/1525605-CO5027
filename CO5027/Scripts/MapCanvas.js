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