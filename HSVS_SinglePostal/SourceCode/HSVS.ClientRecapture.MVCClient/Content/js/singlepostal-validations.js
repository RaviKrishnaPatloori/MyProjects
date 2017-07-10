jQuery(document).ready(function ($) {


    $('#savecontinue').click(function (e) {


        window.onbeforeunload = null;



        var currentTab = getActiveTab();

        if (currentTab == "postcard1") {
            if (!isValid($('#PostalMessage1').val())) {
                e.preventDefault();
                $('#PostalMessage1').focus();
                return false;
            }

            $('#postcardTab2').trigger("click");
        }
        if (currentTab == "postcard2") {

            if (!isValid($('#PostalMessage2').val())) {
                e.preventDefault();
                $('#PostalMessage2').focus();
                return false;
            }

            $('#changetabbutton').trigger("click");
        }
    });

    $('#resetstartover').click(function () {

        //$('#savecomplete').removeClass('disabled');
        //$('#savecontinue').removeClass('disabled');
        //$('#postcardTab2').removeClass('disabled');
        //$('#changetabbutton').removeClass('disabled');
        //$('#postcardTab1').removeClass('disabled');

        var currentTab = getActiveTab();

        if (currentTab == "postcard1") {

            var oldVal = $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage1').text();

            $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage1').val(oldVal);
            $('#' + currentTab).find('.tab-vertical-content').find('#postcardDisplayMessage').text(oldVal);

            $('#showMessage1ErrorView').addClass("hidden").removeClass("active");
            $('#showMessage1Error').addClass("hidden").removeClass("active");

        }
        if (currentTab == "postcard2") {

            var oldVal = $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage2').text();

            $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage2').val(oldVal);
            $('#' + currentTab).find('.tab-vertical-content').find('#postcardDisplayMessage').text(oldVal);

            $('#showMessage2ErrorView').addClass("hidden").removeClass("active");
            $('#showMessage2Error').addClass("hidden").removeClass("active");
        }
        if (currentTab == "postcardSettings") {
            $('#TargetClients').val($('#targetclientsHidden').text());         
        }
    });

    $('#previewpostcard2').click(function () {
        var currentTab = getActiveTab();
        var message = $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage2').val();
        $('#' + currentTab).find('.tab-vertical-content').find('#postcardDisplayMessage').text(message);

        if (!isValid(message)) {

            $('#showMessage2ErrorView').addClass("active").removeClass("hidden");
        }
        else {
            $('#showMessage2ErrorView').addClass("hidden").removeClass("active");
        }
    }
    );

    $('#previewpostcard').click(function () {
        var currentTab = getActiveTab();
        var message = $('#' + currentTab).find('.tab-vertical-content').find('#PostalMessage1').val();
        $('#' + currentTab).find('.tab-vertical-content').find('#postcardDisplayMessage').text(message);

        if (!isValid(message)) {

            $('#showMessage1ErrorView').addClass("active").removeClass("hidden");
        }
        else
        {
            $('#showMessage1ErrorView').addClass("hidden").removeClass("active");
        }
    });

    $('.tab-horizontal-links li').click(function () {
        var currentTab = getActiveTab();
        if (currentTab == "postcard1") {
            $('#savecontinue').show();
            $('#savecomplete').hide();
        }
        if (currentTab == "postcard2") {
            $('#savecontinue').show();
            $('#savecomplete').hide();
        }
        if (currentTab == "postcardSettings") {
            $('#savecontinue').hide();
            $('#savecomplete').show();
        }
    });
    function getActiveTab() {
        return $('.tab-horizontal-links li.active a').attr('data-target');

    }
    function getActiveVerticalTab() {
        return $('.tab-vertical-links li.active').attr('id');
    }

    // MODAL POPUP
    // Get the modal
    var modal = document.getElementById('recaptureModal');

    // Get the button that opens the modal
    var btn = document.getElementById("modalBtn");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal 
    btn.onclick = function () {
        modal.style.display = "block";
    }

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }


    //Prompt message box before leaving the site


    $('#savecomplete').click(function () {
        window.onbeforeunload = null;

        if (!isValid($('#PostalMessage1').val())) {
            $('#postcardTab1').trigger("click");
            $('#PostalMessage1').focus();
            return false;
        }

        if (!isValid($('#PostalMessage2').val())) {         
            $('#postcardTab2').trigger("click");
            $('#PostalMessage2').focus();
            return false;
        }
    });


    $('#settingsLink').click(function () {
        window.onbeforeunload = null;
    });


    $('#performanceLink').click(function () {
        window.onbeforeunload = null;
    });


    $('#communicationLink').click(function () {
        window.onbeforeunload = null;
    });

    window.onbeforeunload = function (e) {
        var message = "There are changes made to the data. Are you sure you want to exit?";
        e = e || window.event;
        if (CheckUnSavedChanges(document.forms['settingsform'])) {
            if (e) {
                e.returnValue = message;
            }
            return message;
        }
    }
    function CheckUnSavedChanges(form) {

        for (var i = 0; i < form.elements.length; i++) {
            var element = form.elements[i];
            var type = element.type;
            if (type == "text" || type == "textarea") {
                if (element.value != element.defaultValue) {
                    return true;
                }
            }
        }
        return false;
    }
    $(function () {
        $('#PostalMessage1').bind('focusout', function (e) {
            if (!isValid($(this).val())) {
                e.preventDefault();
                $(this).focus();
                $('#showMessage1Error').addClass("active").removeClass("hidden");
                //$('#savecontinue').addClass('disabled');
                //$('#postcardTab2').addClass('disabled');
                //$('#changetabbutton').addClass('disabled');
                //$('#showMessage1Error').removeClass('hidden');             

            }
            else {
                $('#showMessage1Error').addClass("hidden").removeClass("active");
                //$('#savecontinue').removeClass('disabled');
                //$('#postcardTab2').removeClass('disabled');
                //$('#changetabbutton').removeClass('disabled');
                //$('#showMessage1Error').addClass('hidden');
            }
        });
    });

    $(function () {
        $('#PostalMessage2').bind('focusout', function (e) {
            if (!isValid($(this).val())) {
                e.preventDefault();
                $(this).focus();
                $('#showMessage2Error').addClass("active").removeClass("hidden");
            }
            else {
                $('#showMessage2Error').addClass("hidden").removeClass("active");
            }
        });
    });

    function isValid(str) {
        if (str.trim().length > 0) {
            return true;
        } else {
            return false;
        }
    }

});


