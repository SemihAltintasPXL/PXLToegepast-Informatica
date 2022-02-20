'use strict';
console.log('start script')
//je mag geen gebruik maken van oude stijl: innerhtml, innertext
/*
button.addEventListener('click',()=>{
    console.log('clickButton')
})
*/
const handleLoad = function (){
    //nodes ophalen
    //eventlisteners koppelen
    let button = document.getElementsByTagName('button')[0];
    button.addEventListener('click', handleClickPress)
};

function handleClickPress(){
    let outputveld = document.querySelector('output');
    if (outputveld.firstChild){
        outputveld.removeChild(outputveld.firstChild);
    }
}


window.addEventListener('load', handleLoad);