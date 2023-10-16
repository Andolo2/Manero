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