window.addEventListener("load", function () {
    var footer = document.querySelector("footer");
    var body = document.querySelector("body");
    var bodyHeight = body.offsetHeight;
    var footerHeight = footer.offsetHeight;



    if (bodyHeight < window.innerHeight) {
        footer.style.position = "fixed";
        footer.style.bottom = "0";
        body.style.paddingBottom = footerHeight + "px";
    }



});

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