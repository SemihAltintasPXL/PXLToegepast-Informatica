'use strict';
console.log("oefening 5 bis");


let forum = document.getElementsByTagName("form")[0];
forum.addEventListener("input", bereken);

function bereken(){
    console.log("in functie bereken");
    let outputVeld = document.getElementsByTagName("output")[0];
    outputVeld.textContent = "";
    let getal1 = document.getElementById("veld1").value;
    let getal2 = document.getElementById("veld2").value;
    let tekst = "";

    if (!getal1 || !getal2){
        tekst = "geef getallen in";
    }
    else{
        tekst = `het product van ${getal1} en ${getal2} is gelijk aan ${getal1 * getal2}`;
    }

    outputVeld.appendChild(document.createTextNode(tekst));
}