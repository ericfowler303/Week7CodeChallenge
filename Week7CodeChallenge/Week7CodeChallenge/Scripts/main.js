$(document).ready(function() {
    // create a selector to select the ajax-links for navigation between get/post actions
    $("header, footer").on("click", ".ajax-links", function() {
        // Get the url for the word that the user clicked on 
        var url = $(this).data("url");

        // Do a get request for that url
        $.get(url, function(urlContent) {
            // get the main div an replace the html data there
            $("#mainBody").html(urlContent);
        });
    });
});