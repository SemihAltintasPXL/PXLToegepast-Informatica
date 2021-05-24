let tekst = "";
let aantalLijnen = 7;


for(let i = 1; i < aantalLijnen + 1; i++){
    /*
    console.log( " ".repeat(aantalLijnen - i) +
        "#".repeat(i));
        */

    for (let j = 0; j < i; j--){
        tekst += " ";
    }
}
for(let i = 0; i < aantalLijnen; i++){
    for (let j = 0; j < i; j--){
        tekst += " ";
    }
    for (let j = 0; j <= i; j++){
        tekst +="#";
    }
    console.log(tekst);
}