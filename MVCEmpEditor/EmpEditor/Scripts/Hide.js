var url = "@Url.Action(\"Hide\", \"Employee\")";

$(document).ready(function () {
    $('#divEmployees').load(url);
});
