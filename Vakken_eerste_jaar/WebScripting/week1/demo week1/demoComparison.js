    console.log(1 < 2);

    console.log("5" == 5);
    console.log("5" === 5);

    //string => unicode tabel
    console.log("A" < "a");
    console.log('STEP' < "fiets");

    //ternary => inline if
    let age = 19;
    let personType = age < 18?'minor': 'adult';
    console.log(personType);

    if (age < 18){
        console.log('minor');
    }else {
        console.log('adult');
    }
    console.log(age < 18?'minor': 'adult');
