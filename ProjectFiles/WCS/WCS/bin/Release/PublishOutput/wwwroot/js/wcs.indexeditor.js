var uri_frontPage = "/api/Settings";

//Start SummerNote
$('#summernote').summernote({
    height: 400,
    focus: true
});

$('#updateFrontPage').click(function () {
    waitOn("Saving");

    var markupText = $('#summernote').summernote('code');
    setting = {
        SettingName: "Front Page Message",
        SettingValue: markupText
    }

    $.ajax({
        url: uri_frontPage,
        type: 'POST',
        accepts: 'text/plain',
        contentType: 'application/json',
        data: JSON.stringify(setting),
        error: function (jqXHR, textStatus, errorThrown) {
            console.error(jqXHR);
        },
        success: function (data) {
            waitOn("Success");
            setTimeout(waitOff, 1500);
        }
    });
});
