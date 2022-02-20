'use strict';
console.log("oefening 4");


functieMetFouten();
function functieMetFouten() {
    /* Dit programma bevat fouten, verbeter ze */
    let teller = 0;
    let boodschap = "teller heeft waarde: ";
    boodschap += teller + "<br/>";
    teller = teller + 10;
    if (teller > 5) {
        boodschap += "<b>Afgelopen</b>, met waarde: " + teller;
        document.getElementById("output").innerHTML = boodschap;
    }
}