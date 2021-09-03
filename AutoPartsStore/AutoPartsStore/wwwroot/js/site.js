
$('#IfNewUser').on('change', function () {
    if ($(this).is(':checked')) {
        $('#login').css('visibility', 'collapse');
        $('#register').css('visibility', 'visible');
    } else {
        $('#login').css('visibility', 'visible');
        $('#register').css('visibility', 'collapse');
    }
})
