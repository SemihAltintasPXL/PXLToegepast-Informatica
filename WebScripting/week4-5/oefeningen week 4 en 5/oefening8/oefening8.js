'use strict'
console.log("oefening 8");

let tekenKnop = document.getElementsByTagName('button')[0];
tekenKnop.addEventListener('click', teken);

function teken(){
    let outputVeld = document.getElementsByTagName("output")[0];
    outputVeld.textContent = "";
    let hoogte = Number (document.getElementById("inputVeld").value);
    let tekst = "";

    for (let rij = 1; rij < hoogte + 1; rij++){
        tekst += "*";
        let paragraaf = document.createElement("p");
        paragraaf.appendChild(document.createTextNode(tekst));
        outputVeld.appendChild(paragraaf);
        console.log(rij + " " + tekst);
    }

}