'use strict'
let para = document.querySelector("p");
let button = document.querySelector("button");
para.addEventListener("mousedown", () => {
    console.log("Handler for paragraph.");
});
button.addEventListener("mousedown", event => {
    console.log("Handler for button.");
    if (event.button == 2) {
        event.stopPropagation();
    }
});