
$('#IfNewUser').on('change', function () {
    if ($(this).is(':checked')) {
        $('#login').css('visibility', 'hidden');
        $('#register').css('visibility', 'visible');
    } else {
        $('#login').css('visibility', 'visible');
        $('#register').css('visibility', 'hidden');
    }
})

$('#partList')
    .load(`/Home/PartsList`)

$('#search').on('click', function () {
    const searchText = $('#searchText').val()

    $('#partList').load(`/Home/PartsList/?search=${searchText}`)
})