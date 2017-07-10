$(function() {
	//$('.hospital-logo h1').lettering('words');

	$('.tab-block .tab-wrap li a').click(function(){
		var tab_id = $(this).attr('data-tab');

		$('.tab-block .tab-wrap li').removeClass('active');
		$('.tab-content > section').removeClass('active');

		$(this).parents('li').addClass('active');
		$("#"+tab_id).addClass('active');
	})


	$('.tool-bar li a').click(function(e) {
		e.preventDefault();
		var tabpanel = $(this).attr('href');
	});

	function disableFlip () {
		if ($('.horizontal-tab.active .tabs-vertical li.edit-card').hasClass('active')) {
			$('.horizontal-tab.active .preview-actions li.flip-card a').addClass('disabled');
		} else if ($('.horizontal-tab.active .tabs-vertical li.msg-template').hasClass('active')) {
			$('.horizontal-tab.active .tabs-vertical li.flip-card a').addClass('disabled');
		} else {
			$('.horizontal-tab.active .preview-actions li.flip-card a').removeClass('disabled');
		}
	}


	$('.preview-actions li a:not(".disabled")').click(function(e){
		e.preventDefault();
		 $(this).parents('.horizontal-tab.active').find('.flip-wrap .card').toggleClass('flipped');
		 $(this).toggleClass('flipped');
	});
	

	disableFlip();

	$('.tabs-vertical li').click(function(e) {
		e.preventDefault();
		disableFlip();
	})




	// Flip Card disabled Option


	// Text Character Limit
	var maxLength = 320;
	$('textarea').keyup(function() {
	  	var length = $(this).val().length;
	  	var length = maxLength-length;
	  	$('#chars').text(length);
	});


	// Textarea Edit Highlights

  	$(".textareaChars").on("click", function(e) {
    	$(".edit-text").addClass("yellow-bg");
    	e.stopPropagation()
  	});
  	$(document).on("click", function(e) {
    	if ($(e.target).is(".edit-text") === false) {
      	$(".edit-text").removeClass("yellow-bg");
    	}
  	});


	// Calendar Picker
	

	if ($('.date-picker').length) {
		$('.date-picker').dcalendarpicker();
	}
	
	
	// Performance Header Links Active

	$('.links li a').on('click', function(){
    	$(this).parent().addClass('active').siblings().removeClass('active');
  	});


	// Vertical Tab
	// jQuery('.tabs-vertical .tab-vertical-links a').on('click', function(e)  {
 //        var currentAttrValue = jQuery(this).attr('href');
 
 //        // Show/Hide Tabs
 //        jQuery('.tabs-vertical ' + currentAttrValue).show().siblings().hide();
 
 //        // Change/remove current tab to active
 //        jQuery(this).parent('li:not(.flip-card)').addClass('active').siblings().removeClass('active');
 
 //        e.preventDefault();
 //    });


// $('ul.tabs li').click(function(){
// 		var tab_id = $(this).attr('data-tab');

// 		$('ul.tabs li').removeClass('current');
// 		$('.tab-content').removeClass('current');

// 		$(this).addClass('current');
// 		$("#"+tab_id).addClass('current');
// 	})




 $('.tab-horizontal-links li a').click(function(e) {
 	e.preventDefault();

 	var tab_id = $(this).attr('data-target');
 	$(this).parent('li').addClass('active').siblings('li').removeClass('active');

 	$('.tab-horizontal-content .tab[data-tab="'+tab_id+'"]').addClass('active').siblings('.tab').removeClass('active');

 });


 $('.tabs-vertical .tab-vertical-links li a').click(function(e) {
 	e.preventDefault();

 	var currentAttrValue = $(this).attr('href');
 	var currentTab = $(this).parents('.horizontal-tab.active');

 	$(this).parents('.horizontal-tab.active').find('.tabs-vertical ' + currentAttrValue).show().siblings().hide();
 	$(this).parent('li:not(.flip-card)').addClass('active').siblings().removeClass('active');

 });


//  jQuery('.tabs-vertical .tab-vertical-links a').on('click', function(e)  {
//  	var currentAttrValue = jQuery(this).attr('href');

//     // Show/Hide Tabs
//     jQuery('.tabs-vertical ' + currentAttrValue).show().siblings().hide();

//     // Change/remove current tab to active
//     jQuery(this).parent('li:not(.flip-card)').addClass('active').siblings().removeClass('active');

//     e.preventDefault();
// });



 });