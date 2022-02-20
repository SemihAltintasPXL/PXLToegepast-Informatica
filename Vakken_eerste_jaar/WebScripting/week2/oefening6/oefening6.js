//methode 1
const reverseArray1 = function(input) {
    let output = [];
    for(let i = input.length - 1; i >= 0; i--){
        output.push(input[i]);
    }
    return output;
};

//methode 2
const reverseArray2 = function(input) {
    let output = [];
    for(let item of input){
        output.unshift(item);
    }
    return output;
};

let a = [1, 2, 3];
let b = reverseArray1(a);
let c = reverseArray2(a);

console.log(a);
console.log(b);
console.log(c);