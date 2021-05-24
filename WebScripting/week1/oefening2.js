/*for(let i = 1; i < 101; i++){
    if (i % 3 == 0 && i % 5 != 0){
        console.log("Fizz");
    }
else if (i % 3 == 0 && i % 5 == 0){
        console.log("FizzBuzz")
    }else{
        console.log(i);
    }
}
*/
for (let x = 1; x <= 100; x++){
    if (x % 5 == 0 && x%3 ==0){
        console.log("fizzbuzz")
    }else if(x % 5 == 0){
        console.log("fizz")
    }else if(x % 3 == 0){
        console.log("buzz")
    }else{
        console.log(x)
    }
}


/*
let minimum = 1;
let maximum = 100;



let uitkomst = "";
for (let rij = 0; rij < maximum; rij++) {
if (rij % 5 === 0 && rij % 3 === 0) {
uitkomst = "FizzBuzz";
} else if (rij % 5 === 0) {
uitkomst = "Buzz";
    } else if (rij % 3 === 0) {
uitkomst = "fizz";
    } else {
uitkomst = rij;
    }
console.log(uitkomst)
}*/

for (let i = 0; i < 100; i++){
    let output = "";
    if (i % 3 == 0){
        output += "fizz"
    }
    if (i % 5==0){
        output += "buzz"
    }
    console.log(output? output:i);
}
