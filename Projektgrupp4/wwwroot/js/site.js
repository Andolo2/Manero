﻿// Kod för slider meny.

document.addEventListener("DOMContentLoaded", function () {
    const menuToggle = document.getElementById("menu-toggle");
    const slideMenu = document.querySelector(".slide-menu");

    // Klickhändelsen för menyknappen
    menuToggle.addEventListener("click", function (e) {
        e.stopPropagation(); // Förhindra att klickhändelsen sprider sig

        if (slideMenu.style.transform === "translateX(0px)") {
            slideMenu.style.transform = "translateX(250px)";
        } else {
            slideMenu.style.transform = "translateX(0px)";
        }
    });

    // Klickhändelse för att stänga "slider" när man klickar utanför den
    document.addEventListener("click", function (event) {
        if (event.target !== slideMenu && event.target !== menuToggle) {
            slideMenu.style.transform = "translateX(-250px)";
            console.log("Press")
        }
    });
});

/////////////////////////////////////////////////////////////////////////////

// Kod för Sticky footer.

document.addEventListener("DOMContentLoaded", function () { // Fäster footer längst ned på sidan i alla lägen.
    const footer = document.querySelector(".Footer-Section footer");

    function setFooterPosition() {
        const windowHeight = window.innerHeight; // Hämta windiwsheight
        const bodyHeight = document.body.clientHeight; // Hämta bodyheght

        if (bodyHeight < windowHeight) {
            const offset = windowHeight - bodyHeight;
            footer.style.position = "fixed";
            footer.style.bottom = "0";
            footer.style.width = "100%";
            footer.style.left = "0";
        } else {
            footer.style.position = "static";
        }
    }

    window.addEventListener("resize", setFooterPosition);
    window.addEventListener("load", setFooterPosition);
    setFooterPosition();
});






//window.addEventListener("load", function () {
//    var footer = document.querySelector("footer");
//    var body = document.querySelector("body");
//    var bodyHeight = body.offsetHeight;
//    var footerHeight = footer.offsetHeight;



//    if (bodyHeight < window.innerHeight) {
//        footer.style.position = "fixed";
//        footer.style.bottom = "0";
//        body.style.paddingBottom = footerHeight + "px";
//    }



//});

const togglePasswordButton = document.getElementById("togglePassword");
const passwordInput = document.getElementById("password");

togglePasswordButton.addEventListener("click", (e) => {
    e.preventDefault(); // Prevent the default button click behavior
    if (passwordInput.getAttribute("type") === "password") {
        passwordInput.setAttribute("type", "text");
        togglePasswordButton.innerHTML = '<i class="fa-sharp fa-solid fa-eye-slash"></i>';
    } else {
        passwordInput.setAttribute("type", "password");
        togglePasswordButton.innerHTML = '<i class="fa-solid fa-eye"></i>';
    }
});

const toggleConfirmPasswordButton = document.getElementById("toggleConfirmPassword");
const confirmPasswordInput = document.getElementById("confirmPassword");

toggleConfirmPasswordButton.addEventListener("click", (e) => {
    e.preventDefault(); // Prevent the default button click behavior
    if (confirmPasswordInput.getAttribute("type") === "password") {
        confirmPasswordInput.setAttribute("type", "text");
        toggleConfirmPasswordButton.innerHTML = '<i class="fa-solid fa-eye-slash"></i>';
    } else {
        confirmPasswordInput.setAttribute("type", "password");
        toggleConfirmPasswordButton.innerHTML = '<i class="fa-solid fa-eye"></i>';
    }
});