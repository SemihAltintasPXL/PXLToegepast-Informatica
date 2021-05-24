    const prompt = require('prompt-sync')();


    let getal = Math.floor(Math.random() * 10 + 1);
    console.log(getal);
    let aantalIngaves = 0;
    let geraden = false;
    //let ingave;
        while (geraden === false && aantalIngaves < 3) {
            console.log(aantalIngaves);
            ingave = Number(prompt("Geef een getal in"));
            aantalIngaves++;
            while ((Number.isNaN(ingave) || ( ingave || ingave > 10)) && aantalIngaves < 3) {
                console.log(aantalIngaves);
                console.log("deze ingave is niet juist");
                ingave = Number(prompt("Geef een getal in"));
                aantalIngaves++;
            }
            if (aantalIngaves <= 3){
                if (getal === ingave) {
                    console.log("Proficiat!");
                    geraden = true;
                }else {
                    console.log("dit is geen juist getal");
                }
            }


        }
        if (!geraden){
            console.log("max aantal kanssen bereikt!helaas!")
        }
