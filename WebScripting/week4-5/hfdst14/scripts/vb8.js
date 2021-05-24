'use strict'
let paras = document.body.getElementsByTagName("p");
for (let para of paras) {
    if (para.getAttribute("data-classified") == "secret") {
        para.remove();
    }
}
let afbeelding = document.getElementsByTagName('img')[0];
afbeelding.src = "img/ostrich.jpg";