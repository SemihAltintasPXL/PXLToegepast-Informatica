let height = 7;
for(let i = 1; i <= height; i++){
    let point = "";
    for(let j = height - i; j > 0; j--){
        point += " ";
    }
    for(let j = i * 2 - 1; j > 0; j--){

        point +=  j % 5 === 0 ? "@": "#";
    }
    console.log(point);
}