$(document).ready(function () {
    $('#show-sidebar').on("click", function () {
        $(".topBar .PageTitle").css("padding-left", "280px");
    })
    $('#close-sidebar').on("click", function () {
        $(".topBar .PageTitle").css("padding-left", "85px");
    })

    $(window).resize(function () {
        if ($(window).width() <= 767) {
            $(".page-wrapper").removeClass("toggled");
        } else {
            $(".page-wrapper").addClass("toggled");
        }
    })
    

    
    $('.mdb-select').materialSelect();
     
        // Init DatetimePicker
    AGMPOP.initFormExtendedDatetimepickers();

    $(function () {
        $('.material-tooltip-main').tooltip();
    })
});


//--prevent string char input

function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode != 46 && charCode > 31
        && (charCode < 48 || charCode > 57))
        return false;

    return true;
}
