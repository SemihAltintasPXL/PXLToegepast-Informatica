'use strict'
console.log("oefening 6")

let groetKnop = document.getElementsByTagName('button')[0];
groetKnop.addEventListener('click', groet);

function groet(){
    console.log("in functie groet");
    let outputVeld = document.getElementsByTagName("output")[0];
    outputVeld.textContent = "";
    let voornaam  =document.getElementById("voornaam").value;
    let achternaam = document.getElementById("achternaam").value;
    let tekst = "";

    if (!voornaam || !achternaam){
        tekst = "Vul alle velden in, a.u.b.";
    }else{
        tekst = `Welkom, ${voornaam} ${achternaam}`;
    }

    outputVeld.appendChild(document.createTextNode(tekst));
}