import WereldObject from "./game/WereldObject";
import Point from "./game/Point";



let point = new WereldObject(new Point(1, 2));


let preElement=document.createElement("pre");
let textNode=document.createTextNode("x = " + point.X + "y = " + point.Y +"\n" );

preElement.appendChild(textNode) ;
document.getElementById('output').appendChild(preElement);
console.log(point)


/*
let point=new Point(1,2);

*/


console.log("test")