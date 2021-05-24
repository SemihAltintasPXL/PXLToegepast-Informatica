'use strict'
function elt(name, ...children) {
    let element = document.createElement(name);
    for (let child of children) {
        if (typeof child == "string") {
            element.appendChild(document.createTextNode(child));
        } else {
            element.appendChild(child);
        }
    }
    return element;
}

document.getElementById("quote").appendChild(
    elt("footer",
        "-",
        elt("strong", "Karl Popper"),
        ", preface to the second editon of ",
        elt("em", "The Open Society and Its Enemies"),
        ", 1950"
    )
);