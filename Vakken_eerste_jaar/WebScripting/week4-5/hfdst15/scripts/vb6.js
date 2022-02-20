'use strict'
let link = document.querySelector("a");
link.addEventListener("click", event => {
    console.log("Nope.");
    event.preventDefault();
});