﻿var geocoder;
var map;
var markers = [];
var marker;


function initialize(value) {
    geocoder = new google.maps.Geocoder();
    var latlng = new google.maps.LatLng(51.68439, 39.185851);
    var mapOptions = {
        zoom: 16,
        center: latlng
    }
    map = new google.maps.Map(document.getElementById("map"), mapOptions);
}

function deleteAllMarkers()
{
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
}

function codeAddressMy() {
    deleteAllMarkers();
    var latitude = document.getElementById('lat').value;
    var longitude = document.getElementById('lng').value;
    var title = document.getElementById('titleOnMark').value;
    /*if (latitude == "" || longitude == "")
    {
        if (marker) {
            marker.setMap(null);
        }
    }
    else {*/
        var myLatlng = new google.maps.LatLng(latitude, longitude);
        map.setCenter(myLatlng);
        marker = new google.maps.Marker({
            position: myLatlng,
            map: map,
            title: title
        });
    //}
        markers.push(marker);
}

function codeAddressWithColor() {
        deleteAllMarkers();
        var latitude = document.getElementById('lat').value;
        var longitude = document.getElementById('lng').value;
        var title = document.getElementById('titleOnMark').value;
        /*if (latitude == "" || longitude == "") {
            setMapOnAll(null);
        }
        else {
            if (marker) {
                marker.setMap(null);
            }*/
            var myLatlng = new google.maps.LatLng(latitude, longitude);
            map.setCenter(myLatlng);
            var rad = document.getElementsByName("flag")
            if (rad[0].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/red.png",
                    title: title
                });
            }
            if (rad[1].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/green.png",
                    title: title
                });
            }
            if (rad[2].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/yellow.png",
                    title: title
                });
            }
    //}     
            markers.push(marker);
    }

function SetMarkersFromTags() {
        var latitude = document.getElementById('lat').value;
        var longitude = document.getElementById('lng').value;
        var title = document.getElementById('titleOnMark').value;
        /*if (latitude == "" || longitude == "") {
            setMapOnAll(null);
        }
        else {*/
            var myLatlng = new google.maps.LatLng(latitude, longitude);
            map.setCenter(myLatlng);
            var rad = document.getElementsByName("flag")
            if (rad[0].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/red.png",
                    title: title
                });
            }
            if (rad[1].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/green.png",
                    title: title
                });
            }
            if (rad[2].checked) {
                marker = new google.maps.Marker({
                    map: map,
                    position: myLatlng,
                    icon: "resources/yellow.png",
                    title: title
                });
            }
        //}
            markers.push(marker);
    }
    
    



