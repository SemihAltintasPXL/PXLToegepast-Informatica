'use strict'
console.log("oefening 7");

let onevenKnop = document.getElementsByTagName('button')[0];
onevenKnop.addEventListener('click', genereer);

function genereer(){
    let outputVeld = document.getElementsByTagName("output")[0];
    outputVeld.textContent = "";
    let teller = 0;
    let getal = document.getElementById("inputVeld").value;
    let tekst = "";
    if (getal <= 50 && getal >= 0){
        while (teller <= getal){
            if (teller % 2 !== 0){
                tekst += " " + teller;
            }
            teller++;
        }
        outputVeld.appendChild(document.createTextNode(tekst));
    }else{
        alert("dit is geen geldig getal!!!!")
    }


}