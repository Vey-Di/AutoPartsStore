
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

$('#imageFile').on('change', function () {
    var file = document.querySelector(
        'input[type=file]')['files'][0];

    var reader = new FileReader();
    console.log("next");

    reader.onload = function () {
        base64String = reader.result.replace("data:", "")
            .replace(/^.+,/, "");

        imageBase64Stringsep = base64String;

        $('#Image').val(base64String)
    }
    reader.readAsDataURL(file);
})

$('.saveFeatureLine').on('submit', function (event) {
    event.preventDefault();
    console.log(this)
    if (this.featureName.value != null || this.featureValue.value != null) {
        $(this).append(`<input type='hidden' value='${this.newFeatureName.value}' name='newFeatureName'/>`)
        $(this).append(`<input type='hidden' value='${this.newFeatureValue.value}' name='newFeatureValue'/>`)
        console.log(this)
        this.submit();
    }
})

$('#addFeature').on('click', function () {
    $('#featuresList').append(
        `<div class="item feature">
            <form method="post" action="/Admin/ChangeFeatureLine" class="saveFeatureLine" >
                <input type="text" id="newFeatureName" class="marginRight">
                <input type="text" id="newFeatureValue">
                <input type="hidden" value="" id="featureName" name="featureName" />
                <input type="hidden" value="" id="featureValue" name="featureValue" />
                <input type="hidden" value="${$('#partId')[0].value}" name="partId" />
                <input type="submit" value="Save" class="btn btn-outline-primary" />
            </form>

            <form method="post" action="/Admin/RemoveFeatureLine">
                <input type="hidden" value="${$('#partId')[0].value}" name="partId" />
                <input type="submit" value="Remove" class="btn btn-outline-danger" />
            </form>
        </div>`
    )
    $('.saveFeatureLine').on('submit', function (event) {
        event.preventDefault();
        console.log(this)
        if (this.featureName.value != null || this.featureValue.value != null) {
            $(this).append(`<input type='hidden' value='${this.newFeatureName.value}' name='newFeatureName'/>`)
            $(this).append(`<input type='hidden' value='${this.newFeatureValue.value}' name='newFeatureValue'/>`)
            console.log(this)
            this.submit();
        }
    })
    console.log($('#partId')[0].value)
})