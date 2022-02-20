function fibonnaci(number){
    if (number === 0){
        return 1;
    }else if (number === 1){
        return 1;
    }else{
        return fibonnaci(number - 2) + fibonnaci(number - 1);
    }
}

console.log(fibonnaci(5));