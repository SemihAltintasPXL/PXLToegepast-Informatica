'use strict'
function replaceImages() {
    let images = document.getElementsByTagName("img");
    for (let i = images.length - 1; i >= 0; i--) {
        let image = images[i];
        if (image.alt) {
            let text = document.createTextNode(image.alt);
            image.parentNode.replaceChild(text, image);
        }
    }
}