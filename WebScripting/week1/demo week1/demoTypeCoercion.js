    console.log("5" + (1));
    console.log(typeof (1 + "5" + (1)))

    console.log("5" * 6)
    console.log(typeof ("5" * 6));

    console.log("tekst" * 6)
    console.log(typeof ("tekst" * 6));

    console.log(8 * null);
    console.log(typeof (8 * null));

    let getal;
    console.log(getal * 8);
    console.log(typeof (getal * 8))

    //truthy false

    console.log(false == 0);
    console.log(false === 0);

    let proof = 0;
    if (proof){
        console.log(`${proof} is truthy`)
    }else {
        console.log(`${proof} is falsy`)
    }
    /*
    truthy      falsy
    "tekst"     undefined
    " "         null
    numbers     0
    []          ""
                NaN(Not a Number)
     */

