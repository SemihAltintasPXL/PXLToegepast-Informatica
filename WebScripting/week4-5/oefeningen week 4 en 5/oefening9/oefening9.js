'use strict';
console.log("oefening 9");

let button = document.getElementsByTagName("button")[0];
button.addEventListener("click", SplitsOp);


function SplitsOp() {
    let email = document.getElementsByTagName("input")[0].value;

    let naam = document.getElementsByTagName("output")[0];
    naam.textContent = "";
    let emailNaam = email.split(".");
    naam.appendChild(document.createTextNode(emailNaam[0]));

    let naam2 = document.getElementsByTagName("output")[1];
    naam2.textContent = "";
    let emailNaam2 = emailNaam[1].split("@");
    naam2.appendChild(document.createTextNode(emailNaam2[0]));

    let subdomein = document.getElementsByTagName("output")[2];
    subdomein.textContent = "";
    subdomein.appendChild(document.createTextNode(emailNaam2[1]));

    let domein = document.getElementsByTagName("output")[3];
    domein.textContent = "";
    domein.appendChild(document.createTextNode(emailNaam[2]));

}
