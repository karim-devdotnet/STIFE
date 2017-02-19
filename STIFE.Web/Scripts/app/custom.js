/// <reference path="~/Scripts/jquery-1.11.1.js">

/*=============================================================
========================================================  */

$(document).ready(function () {
    var iScreenHeight = $(window).height();
    var iHeaderHeight = $('#header-area').innerHeight();
    $("#home .overlay").height(iScreenHeight - 200);
    $(window).resize(function () { $("#home .overlay").height(iScreenHeight - 200); });

    // SCROLL SCRIPTS 
        $('.scroll-me a').bind('click', function (event) { //just pass scroll-me class and start scrolling
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1000, 'easeInOutQuad');
        event.preventDefault();
        });
    // BACKGROUND VIDEO SCRIPTS
        $(function () {
            $(".player").mb_YTPlayer(); // .player - class to add for playing video ( see the div above to understand)
        });

    //LOADING
    window.onload = function () {
        $('.loader').fadeOut(2000, function() {
            $(".animate-bottom").css('display' , 'block');
        });
    }
});
