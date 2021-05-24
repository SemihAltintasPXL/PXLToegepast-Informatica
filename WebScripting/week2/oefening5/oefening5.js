
const maakRij = function (min, max){
    let rij = [];
    for (let teller = min; teller <= max; teller++){
        rij = rij.concat(teller);
    }
    return rij;
};

console.log(maakRij(4, 8)); //[4,5,6,7,8]

const maakRij2 = function (min, max, stap = 1){
    if (stap === 0){
        return undefined;
    }
    let rij = [];
    for (let teller = min; teller <= max; teller += stap){
        rij = rij.concat(teller);
    }
    for (let teller = min; teller >= max; teller += stap){
        rij = rij.concat(teller);
    }
    return rij;
};




console.log(maakRij2(4, 8)); //[4,5,6,7,8]
console.log(maakRij2(1, 5, 2)); //[1, 3, 5]
console.log(maakRij2(5, 1, -2)); //[5, 3, 1]
