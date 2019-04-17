$(function () {
    var tokenAuthUI = '<div class="input"><input placeholder="token here" id="input_token" name="token" type="text" size="25"></div>';

    $(tokenAuthUI).insertBefore('#api_selector div.input:last-child');

    $("#input_apiKey").hide();

    $('#input_token').change(addAuthorization);

    function addAuthorization() {
        var token = encodeURIComponent($('#input_token').val());

        if (token && token.trim() !== "") {
            var apiKeyAuth = new SwaggerClient.ApiKeyAuthorization("Authorization", "Bearer " + token, "header");

            window.swaggerUi.api.clientAuthorizations.add("bearer", apiKeyAuth);

            console.log("Bearer token authorization added!");
        }
    }
});