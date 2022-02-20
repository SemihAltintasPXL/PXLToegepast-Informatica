function minimun (...numbers){
    let kleinste = numbers[0];
    for (let number of numbers){
        if (number < kleinste){
            kleinste = number
        }
    }
    return kleinste;
}

console.log(minimun(6,2,5));
