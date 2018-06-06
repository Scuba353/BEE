// var map, infoWindow, locations;

// $.getJSON("/getLocations", function(response){
//   // locations= response.locations
//   // Handle the response data
// })

// //Displays GoogleMap in the map div of the HTML
//   function initMap() {
//     map = new google.maps.Map(document.getElementById('map'), {
//       center: {lat: 39.8283, lng: -98.5795},
//       zoom: 7
//     });
//     infoWindow = new google.maps.InfoWindow;

//     //Sets center of the map at the current location of the individual
//     if (navigator.geolocation) {
//       navigator.geolocation.getCurrentPosition(function(position) {
//         var pos = {
//           lat: position.coords.latitude,
//           lng: position.coords.longitude
//         };

//         infoWindow.setPosition(pos);
//         infoWindow.setContent('Location found.');
//         infoWindow.open(map);
//         map.setCenter(pos);
//       }, function() {
//         handleLocationError(true, infoWindow, map.getCenter());
//       });
//     } else {
//       //Sets center of map to hardcoded center if browser doesn't support Geolocation
//       handleLocationError(false, infoWindow, map.getCenter());
//     }

//     //creates infowindows for each new marker
//     infoWindow2= new google.maps.InfoWindow({});
//     var marker, i

// //for each address need to somehow geocode the location 
// //Should we get the coords when we save to DB and save them OR just get it when we need to set the markers
// //var geocoder; 
// // function codeAddress() {
// //   var address = document.getElementById('address').value;
// //   geocoder.geocode( { 'address': address}, function(results, status) {
// //     if (status == 'OK') {
// //       map.setCenter(results[0].geometry.location);
// //       var marker = new google.maps.Marker({
// //           map: map,
// //           position: results[0].geometry.location
// //       });
// //     } else {
// //       alert('Geocode was not successful for the following reason: ' + status);
// //     }
// //   });
// // }

//     //loops through markers to set marker locations and populate infowindows
//     for (i=0; i<locations.length; i++){

//       //use the geocoer() here and get the lat and lon of address and then 
//       //if OK set marker, else "location not found error"
//       marker= new google.maps.Marker({
//         position: new google.maps.LatLon(location[i][1], locations[i][2]),
//         map: map
//       });
//       google.maps.event.addListener(marker, 'click', (function (marker, i){
//         return function () {
//           infoWindow2.setContent(locations[i][0]);
//           infoWindow2.open(map, marker);
//         }
//       })(marker,i));
//     }
//   } //end of initMap

//   //function for errors
//   function handleLocationError(browserHasGeolocation, infoWindow, pos) {
//     infoWindow.setPosition(pos);
//     infoWindow.setContent(browserHasGeolocation ?
//                           'Error: The Geolocation service failed.' :
//                           'Error: Your browser doesn\'t support geolocation.');
//     infoWindow.open(map);
//   } //end of handleLocaitonError
















// // var geocoder = new google.maps.Geocoder();

// //         document.getElementById('submit').addEventListener('click', function() {
// //           geocodeAddress(geocoder, map);
// //         });
// //       }

// //       function geocodeAddress(geocoder, resultsMap) {
// //         var address = document.getElementById('address').value;
// //         geocoder.geocode({'address': address}, function(results, status) {
// //           if (status === 'OK') {
// //             resultsMap.setCenter(results[0].geometry.location);
// //             var marker = new google.maps.Marker({
// //               map: resultsMap,
// //               position: results[0].geometry.location
// //             });
// //           } else {
// //             alert('Geocode was not successful for the following reason: ' + status);
// //           }
// //         });
// //       }