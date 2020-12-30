jQuery(document).ready(function($) {

	$(".headroom").headroom({
		"tolerance": 20,
		"offset": 50,
		"classes": {
			"initial": "animated",
			"pinned": "slideDown",
			"unpinned": "slideUp"
		}
	});

});

$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.yukarikaydir').fadeIn();
        } else {
            $('.yukarikaydir').fadeOut();
        }
    });

    $('.yukarikaydir').click(function () {
        $("html, body").animate({
            scrollTop: 0
        }, 600);
        return false;
    });
});