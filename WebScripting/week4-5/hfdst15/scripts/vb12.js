'use strict'
const handleLoad = () => {
    let button = document.querySelector("button");
    button.addEventListener("click", handleClick);
}

const handleClick = (event) => {
    console.log(event.target.textContent);
}

window.addEventListener("load", handleLoad);