'use strict';
console.log('oef5')

let rekenKnop = document.getElementsByTagName('button')[0]
//let rekenKnop = document.querySelector('button') dit is voor 1 ding
rekenKnop.addEventListener('click', bereken);

function bereken(){
    console.log('in functie bereken')
    let outputVeld = document.getElementsByTagName('output')[0];
    outputVeld.textContent="";
    let getal1 = document.getElementById('veld1').value;
    let getal2 = document.getElementById('veld2').value;
    console.log(getal1)
    let tekst = "";
    if (!getal1 || !getal2){
        tekst="geef getallen in";
    }
    else if (isNaN(getal1) || isNaN(getal2)){
        tekst = "U heeft geen geldige getallen ingegeven";
    }
    else {
        tekst = `Het product van ${getal1} en ${getal2} is gelijk aan ${getal1 * getal2}`;
    }
    outputVeld.appendChild(document.createTextNode(tekst));

}