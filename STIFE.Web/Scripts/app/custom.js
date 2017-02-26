/// <reference path="~/Scripts/jquery-1.11.1.js">

/*=============================================================
========================================================  */

$(document).ready(function () {
    var iScreenHeight = $(window).height();
    var iHeaderHeight = $('#header-area').innerHeight();
    $("#home .overlay").height(iScreenHeight - 100);
    $(window).resize(function () { $("#home .overlay").height(iScreenHeight - 100); });

    // SCROLL SCRIPTS 
        $('.scroll-me a').bind('click', function (event) { //just pass scroll-me class and start scrolling
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1000, 'easeInOutQuad');
        event.preventDefault();
        });
    // BACKGROUND VIDEO SCRIPTS
        //$(function () {
        //    $(".player").mb_YTPlayer(); // .player - class to add for playing video ( see the div above to understand)
    //});
        if (!jQuery.browser.mobile) {
            $(".player").mb_YTPlayer();
        }

    //LOADING
    //// loader-page den ganzen content bedecken lassen
    //var bPageCurtainHeight = $(document).outerHeight();
    //$('.loader').height(bPageCurtainHeight);

    window.onload = function () {
        $('.loader').fadeOut(2000, function () {
            $(".body-content").css('display', 'block');
            $(".animate-bottom").css('display' , 'block');
        });
    }

    // Closes the Responsive Menu on Menu Item Click
    $('.navbar-collapse ul li a').click(function () {
        $('.navbar-toggle:visible').click();
    });

    // Google Maps Scripts
    // When the window has finished loading create our google map below
    //google.maps.event.addDomListener(window, 'load', initialize);
});

//function myMap() {
//    var myCenter = new google.maps.LatLng(35.711174, 10.000777);
//    var mapProp = { center: myCenter, zoom: 12, scrollwheel: false, draggable: false, mapTypeId: google.maps.MapTypeId.ROADMAP };
//    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
//    var marker = new google.maps.Marker({ position: myCenter });
//    marker.setMap(map);
//}

////var myCenter = new google.maps.LatLng(35.711174, 10.000777);
//var myCenter = new google.maps.LatLng(53.4577326, 9.9828083);
//function initialize() {
//    var mapProp = {
//        center: myCenter,
//        zoom: 13,
//        panControl: true,
//        zoomControl: true,
//        mapTypeControl: true,
//        scaleControl: true,
//        streetViewControl: true,
//        overviewMapControl: true,
//        rotateControl: true,
//        mapTypeId: google.maps.MapTypeId.ROADMAP
//    };
//    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);

//    //var marker = new google.maps.Marker({
//    //    position: myCenter,
//    //    animation: google.maps.Animation.DROP,
//    //    //icon: '../content/img/logo.png'
//    //    icon: 'https://maps.google.com/mapfiles/ms/micons/blue-dot.png'
//    //});

//    //marker.setMap(map);

//    //var contentString = '<b>Société Tuniso-Italienne de Friperie et Effilochage</b><br/>';
//    //contentString += '<span style="color:red;">Z.I. EL BATEN</span><br/>';
//    //contentString += '<span style="color:red;">3100 Kairouan Tunisia</span><br/>';
//    //contentString += '<span style="color:red;">Telefon: +216 77 30 26 04</span>';

//    //var infowindow = new google.maps.InfoWindow({
//    //    position: myCenter,
//    //    content: contentString
//    //});

//    //infowindow.open(map, marker);
//}
