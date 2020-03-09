$(document).ready(function () {
    $('#show-sidebar').on("click", function () {
        $(".topBar .PageTitle").css("padding-left", "280px");
    })
    $('#close-sidebar').on("click", function () {
        $(".topBar .PageTitle").css("padding-left", "85px");
    })
    // Material Select Initialization
    //$(window).resize(function () {
    //    $(".page-content").height($(window).height() - $(".topBar").height());

    //})
    //$(window).ready(function () {
    //    $(".page-content").height($(window).height() - $(".topBar").height());

    //})
    $('.mdb-select').materialSelect();
     
        // Init DatetimePicker
    AGMPOP.initFormExtendedDatetimepickers();

    $(function () {
        $('.material-tooltip-main').tooltip();
    })
});