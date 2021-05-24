'use strict';
console.log("oefening 10");

let button = document.getElementsByTagName("button")[0];
button.addEventListener("click", genereerTekst);

function genereerTekst(){
    let dag = document.getElementsByTagName("input")[0].value;
    let outputVeld = document.getElementsByTagName("output")[0];

    switch (dag){
        case "maandag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de eerste dag van de week"));
            break;
        case "dinsdag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de tweede dag van de week"));
            break;
        case "woensdag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de derde dag van de week"));
            break;
        case "donderdag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de vierde dag van de week"));
            break;
        case "vrijdag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de vijfde dag van de week"));
            break;
        case "zaterdag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de zesde dag van de week"));
            break;
        case "zondag":
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de zevende dag van de week"));
            break;
        default:
            outputVeld.textContent = "";
            outputVeld.appendChild(document.createTextNode("is de niet-bestaande dag van de week"));
    }
}
