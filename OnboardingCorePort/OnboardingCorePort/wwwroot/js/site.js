$("a[href^='#']").click(function (e) {
    e.preventDefault();

    var position = $($(this).attr("href")).offset().top;

    $("body, html").animate({
        scrollTop: position
    } /* speed */);


});

$('.card-text').each(function () {
    var changePipes = $(this).text().replace(/[|]/g, "<boldPipes>| </boldPipes>");
    $(this).html(changePipes);
});

$(document).ready(function () {
    $('.showIntro').show();
});

$(document).ready(function () {
    $('#showall').click(function () {
        $('.targetDiv').show();
    });
    $('.showSingle').click(function () {
        $('.targetDiv').hide();
        $('#div' + $(this).attr('target')).show();
    });
});

$(document).ready(function () {
    $('#div1').load('index.html', function () {
        $(this).show();
    });
});

//Scroll To Top
function scrollToTop() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera

    $("#singlePage").animate({ scrollTop: 0 }, "fast");
}


//Daniel's JS DO NOT TOUCH
function hitURL(path) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            console.log("Success");
            console.log(xhttp.response);
        }
    }
    xhttp.open("GET", path, true);
    xhttp.send();
};



$('.container').ready(function () {
    openPrivacyModal();
});

function openPrivacyModal() {
    console.log("opening modal");
    $('#privacyModal').modal('show')
}

function completed(partialname) {
    var image = $("#" + partialname + "Check");
    if (image.length) {
        console.log("image gathered");
    } else {
        image = $('<img id="' + partialname + 'Check">');
        image.attr("src", "/Content/image/completed.png");
        image.hide();
        $("#" + partialname + "ListItem").append(image);
        image.fadeIn();
    }
}

$(document).ready(function () {
    var progressValue = (100 * parseFloat($('#progressBarOne').css('width')) / parseFloat($('#progressBarOne').parent().css('width'))) + '%';
    var progressValueNum = parseFloat(progressValue);
    $("#progressBarOne").text(progressValueNum.toFixed(0) + "%");
    $("#progressBarOne").css('font-size', '16px');
});

$(document).ready(function () {
    $('#pinDiv').hide();
    $("#showPrint").hide();
    $("#printPinBtn").hide();

});
$(document).ready(function () {
    $("#showPrint").click(function () {
        $("#printDivBtn").show();
        $("#printPinBtn").hide();
        $("#printingDiv").show();
        $("#pinDiv").hide();
        $("#showPrint").hide();
        $("#showPIN").show();
    });
    $("#showPIN").click(function () {
        $("#printDivBtn").hide();
        $("#printPinBtn").show();
        $("#pinDiv").show();
        $("#printingDiv").hide();
        $("#showPIN").hide();
        $("#showPrint").show();
    });
});

$(document).ready(function () {
    $('#klondyke').hide();
    $("#ballykelly").hide();

});

$('#carouselExampleIndicators').on('slide.bs.carousel', function (e) {
    //according to the documentation this event is fired when the slide method is invoked
    var slideTo = $(e.relatedTarget).index();
    if (slideTo == 0) {
        $("#dundonald").show();
        $("#klondyke").hide();
        $("#ballykelly").hide();
    } else if (slideTo == 1) {
        $("#klondyke").show();
        $("#dundonald").hide();
        $("#ballykelly").hide();
    } else if (slideTo == 2) {
        $("#ballykelly").show();
        $("#dundonald").hide();
        $("#klondyke").hide();
    } else {
        $("#dundonald").show();
        $("#klondyke").hide();
        $("#ballykelly").hide();
    };
});

function highlightList(listname) {
    $('#NeuedaIntroListItem').removeAttr('style');
    $('#DAERAList').removeAttr('style');
    $('#CompanyRelationsListItem').removeAttr('style');
    $('#OrgList').removeAttr('style');
    $('#InfoSecList').removeAttr('style');
    $('#HealthList').removeAttr('style');
    $('#FireList').removeAttr('style');
    $('#DisplayScreenEquipmentAwarenessListItem').removeAttr('style');
    $('#SiteInfoListItem').removeAttr('style');
    $('#ICTListItem').removeAttr('style');
    $('#PoliciesListItem').removeAttr('style');
    $('#daeraBottomList').removeAttr('style');
    $('#DSDList').removeAttr('style');
    $('#ISUList').removeAttr('style');
    $('#DSDOrgList').removeAttr('style');
    $('#itSpecific').removeAttr('style');
    $('#healthCourseList').removeAttr('style');
    $('#fireCourseList').removeAttr('style');
    $("#" + listname).css('color', '#1babe0');
}

function removeHighlight() {
    $('#NeuedaIntroListItem').removeAttr('style');
    $('#DAERAList').removeAttr('style');
    $('#CompanyRelationsListItem').removeAttr('style');
    $('#OrgList').removeAttr('style');
    $('#InfoSecList').removeAttr('style');
    $('#HealthList').removeAttr('style');
    $('#FireList').removeAttr('style');
    $('#DisplayScreenEquipmentAwarenessListItem').removeAttr('style');
    $('#SiteInfoListItem').removeAttr('style');
    $('#ICTListItem').removeAttr('style');
    $('#PoliciesListItem').removeAttr('style');
    $('#daeraBottomList').removeAttr('style');
    $('#DSDList').removeAttr('style');
    $('#ISUList').removeAttr('style');
    $('#DSDOrgList').removeAttr('style');
    $('#itSpecific').removeAttr('style');
    $('#healthCourseList').removeAttr('style');
    $('#fireCourseList').removeAttr('style');
}

function printDiv() {

    window.print();

}

function openModals(modal) {
    $(modal).modal('show');
}

function openPolicies(policyLink) {
    window.open(policyLink, '_blank');
}

$('.hoverCard').css('cursor', 'pointer');


/* collapse accordion links */
$(function () {
    $('#securityCheck').click(function () {
        $('#securityBtn').prop('disabled', !$('#securityCheck:checked').length);
    });
});

$(function () {
    $('#itSecurityCheck').click(function () {
        $('#itSecurityBtn').prop('disabled', !$('#itSecurityCheck:checked').length);
    });
});

$(function () {
    $('#itSecurityCheck').click(function () {
        $('#itSecurityBtnProg').prop('disabled', !$('#itSecurityCheck:checked').length);
    });
});

$(function () {
    $('#healthCheck').click(function () {
        $('#healthBtn').prop('disabled', !$('#healthCheck:checked').length);
    });
});
$(function () {
    $('#healthCheck').click(function () {
        $('#healthBtnProg').prop('disabled', !$('#healthCheck:checked').length);
    });
});

$(function () {
    $('#fireCheck').click(function () {
        $('#fireBtn').prop('disabled', !$('#fireCheck:checked').length);
    });
});
$(function () {
    $('#fireCheck').click(function () {
        $('#fireBtnProg').prop('disabled', !$('#fireCheck:checked').length);
    });
});

$(function () {
    $('#displayAwareCheck').click(function () {
        $('#displayAwareBtn').prop('disabled', !$('#displayAwareCheck:checked').length);
    });
});

$(function () {
    $('#displayAwareCheck').click(function () {
        $('#displayAwareBtnProg').prop('disabled', !$('#displayAwareCheck:checked').length);
    });
});

$(function () {
    $('#privacyCheckbox').click(function () {
        $('#privacyModalBtn').prop('disabled', !$('#privacyCheckbox:checked').length);
    });
});


$('.collapseAccordion').click(function (e) {
    $('.collapse').collapse('hide');
});

/* expand DAERA intro on next button click on neueda intro */

$('.showNeuedaIntro').click(function (e) {
    $('.showAccordionDearaIntro').collapse('show');
});

$('.collapseBusinessAreas').click(function (e) {
    $('.collapseAccordionBusinessAreas').collapse('hide');
});

$('.showOrgStruct').click(function (e) {
    $('.showAccordionOrgStruct').collapse('show');
});

$('.collapseOrgStruct').click(function (e) {
    $('.collapseAccordionOrgStruct').collapse('hide');
    $('.showAccordionInfoSecurity').collapse('show');
});

$('.showHealthSafety').click(function (e) {
    $('.showAccordionHealthSafety').collapse('show');
    $('.showAccordionInfoSecurity').collapse('hide');
});

$('.showFireTraining').click(function (e) {
    $('.showAccordionFireTraining').collapse('show');
    $('.showAccordionHealthSafety').collapse('hide');
});

$('.collapseFireTraining').click(function (e) {
    $('.collapseAccordionFireTraining').collapse('hide');
});

/* Accordion actions for previous buttons */

$('.hideOrgStruct').click(function (e) {
    $('.collapseAccordionOrgStruct').collapse('hide');
});

$('.hideDaeraIntro').click(function (e) {
    $('.showAccordionDearaIntro').collapse('hide');
});

$('.showDaeraIntro').click(function (e) {
    $('.showAccordionDearaIntro').collapse('show');
});

$('.showOrgStructHideInfoSecurity').click(function (e) {
    $('.collapseAccordionOrgStruct').collapse('show');
    $('.showAccordionInfoSecurity').collapse('hide');
});

$('.showInfoSecurityHideHealthSafety').click(function (e) {
    $('.showAccordionInfoSecurity').collapse('show');
    $('.showAccordionHealthSafety').collapse('hide');
});

$('.showHealthSafetyHideFireTraining').click(function (e) {
    $('.showAccordionHealthSafety').collapse('show');
    $('.showAccordionFireTraining').collapse('hide');
});

$('.showFireTrainingFromDSA').click(function (e) {
    $('.showAccordionFireTraining').collapse('show');
});

/*Progress Bar - sets percentage value text on bar when page is loaded */
/* Gets current width percentage and adds 12.5% when section is completed. If at 100% stop adding 12.5%. */
function addProgress() {
    var progressValue = (100 * parseFloat($('#progressBarOne').css('width')) / parseFloat($('#progressBarOne').parent().css('width'))) + '%';
    var progressValueNum = parseFloat(progressValue);
    if (progressValueNum < 99) {
        var finalValue = (progressValueNum + 16.6);
        $('#progressBarOne').css('width', finalValue + "%");
        $("#progressBarOne").text(finalValue.toFixed(0) + "%");

    }
    else {
        $('#progressBarOne').css('width', "100%");
        $("#progressBarOne").text("100%");

    }

    if (finalValue >= 95) {
        $('#progressBarOne').css('background-color', '#56a773')
    }
}

$("#neuedaIntroBtn").one("click", function () {
    addProgress();
});

$("#busAreaBtn").one("click", function () {
    addProgress();
});

$("#companyRelBtn").one("click", function () {
    addProgress();
});

$("#orgBtnProg").one("click", function () {
    addProgress();
});

$("#itSecurityBtnProg").one("click", function () {
    addProgress();
});

$("#healthBtnProg").one("click", function () {
    addProgress();
});

$("#fireBtnProg").one("click", function () {
    addProgress();
});

$("#displayAwareBtnProg").one("click", function () {
    addProgress();
});



function openForm() {
    document.getElementById("myForm").style.display = "block";
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
}

function postFeedback(feedback) {
    var pageName = $('#setDataPageID').val();
    var isThumbsUp = feedback == 1;
    console.log(pageName);
    $.ajax({
        method: 'POST',
        url: 'Home/LikesSubmit',
        type: 'post',
        dataType: 'json',
        data: {
            Like_Dislike: isThumbsUp,
            PageName: pageName
        }
    });
}


/* setting the id element of a page on button click when navigating to the specific page*/

(function () {
    let el = document.querySelectorAll('.getPageIdById');

    for (let x = 0; x < el.length; x++) {

        el[x].addEventListener('click', (evt) => {
            evt.preventDefault();
            console.log(el[x].dataset.pageId);
            addPageId(el[x].dataset.pageId);
        })
    }
})()

let addPageId = function (newId) {
    let thumbBtn = document.querySelectorAll('#setDataPageID');

    for (let x = 0; x < thumbBtn.length; x++) {
        thumbBtn[x].dataset.pageId = newId;
        thumbBtn[x].value = newId;
    }
}


/* Instantiate Quill */
$(".setQuillHere").each(function (index) {


    var parentEl = this.parentElement;

    var inputHolder = parentEl.getElementsByTagName('input')[0].value;
    //console.log(inputHolder)
    var quill = new Quill(this, {
        modules: {
            syntax: true,
            toolbar: [
                [{ 'size': ['small', false, 'large', 'huge'] }],  // custom dropdown
                [{ 'header': [1, 2, 3, 4, 5, 6, false] }],
                [{ 'font': [] }],
                [{ 'align': [] }],
                [{ 'color': [] }, { 'background': [] }],          // dropdown with defaults from theme
                [{ 'list': 'ordered' }, { 'list': 'bullet' }],
                ['bold', 'italic', 'underline', 'strike'],        // toggled buttons
                [{ 'script': 'sub' }, { 'script': 'super' }],      // superscript/subscript
                [{ 'indent': '-1' }, { 'indent': '+1' }],          // outdent/indent
                [{ 'direction': 'rtl' }],                         // text direction
                ['link', 'image', 'video'],
                ['blockquote', 'code-block']
            ]
        },
        placeholder: 'Compose an epic...',
        theme: 'snow'
    });

    quill.on("text-change", function () {
        var parentEl = quill.root.parentElement.parentElement;
        var quillData = JSON.stringify(quill.getContents());
        var Html = validHtml(quillData);
        if (!Html.IsValid) {

            // Create tags warning element
            var warning = document.createElement('div')
            warning.className = 'alert alert-danger tagErrorAlert'
            warning.attributes.role = "alert";
            warning.innerText = Html.InValidName + ' Tags are not aload';

            // Append said element
            quill.root.parentElement.parentElement.appendChild(warning);

            quill.root.classList.add('tagError');
            quill.disable();

            setTimeout(function () {
                quill.root.classList.remove('tagError');
                quill.enable();

                // Remove tags warning element
                removeTagAlert()
            }, 3000)
        }
        parentEl.getElementsByTagName('input')[0].value = quillData;
    })

    if (inputHolder !== undefined && inputHolder.length > 0) {
        quill.setContents(JSON.parse(inputHolder))
    }

})


/* Generating base64 image */
$(".neuedaIntroImages").each(function () {

    var firstParEl = this.parentElement.parentElement.parentElement;
    var ImageView = firstParEl.parentElement.previousElementSibling.getElementsByTagName('img')[0];


    function encodeImageFileAsURL(cb) {
        return function () {

            var file = this.files[0];
            var reader = new FileReader();
            reader.onloadend = function () {
                cb(reader.result);
            }
            reader.readAsDataURL(file);
        }
    }

    $(this).change(encodeImageFileAsURL(function (base64Img) {

        firstParEl.getElementsByTagName('input')[0].value = base64Img;
        ImageView.src = base64Img
    }));
})

/* Build Html for frontend view */
$(".quillTranslate").each(function () {

    var quill = new Quill(this, {
        modules: {
            syntax: true,
            toolbar: [
            ]
        },
    });

    var IsDelta = this.innerText;
    if (IsDelta.length > 0) {
        quill.setContents(JSON.parse(IsDelta))
    }

    quill.disable()

})

function removeTagAlert() {
    var alerts = document.querySelectorAll('.alert.alert-danger.tagErrorAlert')

    for (var x = 0; x < alerts.length; x++) {

        alerts[x].parentElement.removeChild(alerts[x].parentElement.childNodes[alerts[x].parentElement.childNodes.length - 1]);
    }
}

function validHtml(html) {

    var sanitizedHtml = HtmlSanitizer;
    sanitizedHtml.SanitizeHtml(html)

    return sanitizedHtml;
}

/* Flash Notifier
 * Can handle a single string or array of strings
 * */
function buildJsNotiferEl(message, severity) {
    /*
     Severity Level:
     success
     info
     warn
     */
    var hasSeverity = false;
    var severityMessageEl = document.createElement("div");
    severityMessageEl.setAttribute("role", "alert");

    if (severity === "success") {
        hasSeverity = true;
        severityMessageEl.classList = "alert alert-success";

    } else if (severity === "info") {
        hasSeverity = true;
        severityMessageEl.classList = "alert alert-info";
    }
    else if (severity === "warn") {
        hasSeverity = true;
        severityMessageEl.classList = "alert alert-warning";
    }

    if (Array.isArray(message) && hasSeverity) {
        for (var x = 0; x < message.length; x++) {
            severityMessageEl.innerHTML += message[x] + "<br>";
        }
    }
    else if (typeof message === "string" && hasSeverity) {
        severityMessageEl.innerText = message;
    } else {
        return undefined;
    }

    return severityMessageEl;
}

function jsNotifer(message, severity) {
    /*
    Severity Level:
    success
    info
    warn
    */
    var notiferTarget = document.getElementById('jsNotifier');
    var isEl = buildJsNotiferEl(message, severity);
    var hasEl = (isEl === undefined) ? false : isEl;

    if (hasEl) {

        notiferTarget.appendChild(isEl)

        setTimeout(function () { notiferTarget.removeChild(isEl) }, 3000)

    } else {
        console.log("Something went wrong building notification.")
    }

}

+

    $("#submitUserFeedbackForm").click(function (evt) {
        evt.preventDefault();
        closeForm()

        $.ajax({
            url: "Home/FeedbackSubmit",
            type: "post",
            dataType: "json",
            data: {
                UserFeedback: {
                    CategoryID: this.form.UserFeedback_CategoryID.value,
                    LevelSatisfiedID: this.form.UserFeedback_LevelSatisfiedID.value,
                    Comments: this.form.UserFeedback_Comments.value
                }
            },
            success: function (res) {
                if (res.success) {
                    jsNotifer("Feedback has been sent successfully", "success");
                } else {
                    jsNotifer("Sorry Feedback didn't send, please try again", "warn");
                }
            }
        })
    })

