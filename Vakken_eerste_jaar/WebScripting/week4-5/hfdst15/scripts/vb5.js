'use strict'
document.body.addEventListener("click", event => {
    if (event.target.nodeName == "BUTTON") {
        console.log("Clicked", event.target.textContent);
    }
});