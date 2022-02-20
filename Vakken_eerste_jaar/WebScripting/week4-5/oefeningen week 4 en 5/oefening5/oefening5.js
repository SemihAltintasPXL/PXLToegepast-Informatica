'use strict';
console.log("oefening 5");


let rekenKnop = document.getElementsByTagName('button')[0];
rekenKnop.addEventListener('click', bereken);

function bereken(){
    console.log("in functie bereken");
    let outputVeld = document.getElementsByTagName("output")[0];
    outputVeld.textContent = "";
    let getal1  =document.getElementById("veld1").value;
    let getal2 = document.getElementById("veld2").value;
    let tekst = "";

    if (!getal1 || !getal2){
        tekst = "geef getallen in";
    } else if (isNaN(getal1) || isNaN(getal2)){
        tekst = "u heeft geen geldige getallen ingegeven";
    }else{
        tekst = `het product van ${getal1} en ${getal2} is gelijk aan ${getal1 * getal2}`;
    }

    outputVeld.appendChild(document.createTextNode(tekst));
}
