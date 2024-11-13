//document.addEventListener("DOMContentLoaded", function () {
//    var prevScrollpos = window.pageYOffset;
//    var navbar = document.getElementById("navbar");
//    var contentContainer = document.querySelector(".main-content");

//    window.onscroll = function () {
//        var currentScrollPos = window.pageYOffset;
//        if (prevScrollpos > currentScrollPos) {
//            navbar.classList.remove("nav-hidden");
//            contentContainer.classList.remove("nav-hidden");
//            contentContainer.style.marginTop = "80px"; // Ensure it's set to the default value
//        } else {
//            navbar.classList.add("nav-hidden");
//            contentContainer.classList.add("nav-hidden");
//            contentContainer.style.marginTop = "20px"; // Adjusted value when hidden
//        }
//        prevScrollpos = currentScrollPos;
//    };
//});

//setTimeout(function () {
//    document.getElementById("submissionSuccessMessage").style.display = 'none';
//}, 10000);

//document.addEventListener("DOMContentLoaded", function () {
//    var prevScrollpos = window.pageYOffset;
//    var navbar = document.getElementById("navbar");
//    var contentContainer = document.querySelector(".main-content");
//    var partialViews = document.querySelectorAll('.partial-view');
//    var currentViewIndex = 0;

//    // Hide all partial views except the first one
//    for (var i = 1; i < partialViews.length; i++) {
//        partialViews[i].classList.add('d-none');
//    }

//    window.onscroll = function () {
//        // Navbar behavior
//        var currentScrollPos = window.pageYOffset;
//        if (prevScrollpos > currentScrollPos) {
//            navbar.classList.remove("nav-hidden");
//            contentContainer.classList.remove("nav-hidden");
//            contentContainer.style.marginTop = "80px"; // Ensure it's set to the default value
//        } else {
//            navbar.classList.add("nav-hidden");
//            contentContainer.style.marginTop = "20px"; // Adjusted value when hidden
//        }
//        prevScrollpos = currentScrollPos;
        
//        // Partial views behavior
//        var scrollPosition = window.scrollY || document.documentElement.scrollTop;
//        var threshold = 100;

//        // Determine if the user has scrolled to the bottom of the current partial view
//        var currentPartialView = partialViews[currentViewIndex];
//        var currentPartialViewBottom = currentPartialView.offsetTop + currentPartialView.offsetHeight;

//        // If scrolled to the bottom of the current partial view, show the next one
//        if (scrollPosition > currentPartialViewBottom - threshold) {
//            showNextPartialView();
//        }
//    };

//    // Function to show a specific partial view
//    function showNextPartialView() {
//        if (currentViewIndex < partialViews.length - 1) {
//            partialViews[currentViewIndex].classList.add('d-none');
//            currentViewIndex++;
//            partialViews[currentViewIndex].classList.remove('d-none');

//            // Adjust margin after showing the next partial view
//            contentContainer.style.marginTop = "80px";
//        }
//    }
//});


//document.addEventListener("DOMContentLoaded", function () {
//    var navbar = document.getElementById("navbar");
//    var contentContainer = document.querySelector(".main-content");
//    var partialViews = document.querySelectorAll('.partial-view');
//    var currentViewIndex = 0;

//    // Set initial margin-top based on whether it's the index page or not
//    contentContainer.style.marginTop = document.body.classList.contains('index-page') ? "0" : "80px";

//    // Hide all partial views except the first one
//    for (var i = 1; i < partialViews.length; i++) {
//        partialViews[i].classList.add('d-none');
//    }

//    window.onscroll = function () {
//        // Navbar behavior
//        var scrollPosition = window.scrollY || document.documentElement.scrollTop;
//        var threshold = 900;

//        // Determine if the user has scrolled to the bottom of the current partial view
//        var currentPartialView = partialViews[currentViewIndex];
//        var currentPartialViewBottom = currentPartialView.offsetTop + currentPartialView.offsetHeight;

//        // If scrolled to the bottom of the current partial view, show the next one
//        if (scrollPosition > currentPartialViewBottom - threshold) {
//            showNextPartialView();
//        }

//        if (scrollPosition >= currentPartialViewBottom - window.innerHeight && scrollPosition <= documentHeight) {
//            showNextPartialView();
//        }
//    };

//    // Function to show a specific partial view
//    function showNextPartialView() {
//        // Hide the current partial view
//        partialViews[currentViewIndex].classList.add('d-none');

//        // Increment index to the next partial view
//        currentViewIndex = (currentViewIndex + 1) % partialViews.length;

//        // Show the next partial view
//        partialViews[currentViewIndex].classList.remove('d-none');

//        // Only adjust margin if not on the index page
//        if (!document.body.classList.contains('index-page')) {
//            contentContainer.style.marginTop = "80px";
//        }
//    }
//});


