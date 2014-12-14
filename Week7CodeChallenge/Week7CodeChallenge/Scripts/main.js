$(document).ready(function() {
    // create a selector to select the ajax-links for navigation between get/post actions
    $("body").on("click", ".ajax-link", function() {
        // Get the url for the word that the user clicked on 
        var url = $(this).data("url");
       
        // Do a get request for that url
        $.get(url, function(urlContent) {
            // get the main div an replace the html data there
            $("#mainBody").html(urlContent);
        });
    });

    // For the about page tabs links
    $("body").on("click", ".ajax-tab", function () {
        // Get the url for the word that the user clicked on 
        var url = $(this).data("url");

        // Do a get request for that url
        $.get(url, function (urlContent) {
            // get the main div an replace the html data there
            $(".tab-content").html(urlContent);
        });
    });


    // hookup the post for the contact form page
    $('body').on('submit', '.ajax-form', function (event) {
        //preventing the default behavior so the form doesn't try to submit
        event.preventDefault();
        
        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            //update our content area
            $('.ajax-form-content').html(data);
        });
    });
});