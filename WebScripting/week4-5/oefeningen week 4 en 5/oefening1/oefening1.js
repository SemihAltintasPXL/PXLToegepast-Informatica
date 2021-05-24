'use strict';
console.log("start oefening 1");
const MOUNTAINS = [
    {name: "Kilimanjaro", height: 5895, place: "Tanzania"},
    {name: "Everest", height: 8848, place: "Nepal"},
    {name: "Mount Fuji", height: 3776, place: "Japan"},
    {name: "Vaalserberg", height: 323, place: "Netherlands"},
    {name: "Denali", height: 6168, place: "United States"},
    {name: "Popocatepetl", height: 5465, place: "Mexico"},
    {name: "Mont Blanc", height: 4808, place: "Italy/France"}
];


let heading = Object.keys(MOUNTAINS[0]);
let placeInHtml = document.getElementById("mountains");
let mountainTable = document.createElement("table");
let tableHead = document.createElement("thead");


for (let item of heading){
    let columsName = document.createElement("th");
    columsName.appendChild(document.createTextNode(item));
    tableHead.appendChild(columsName);
}

for (let row = 0; row < MOUNTAINS.length; row++){
    let tableRow = document.createElement("tr");
    for (let data = 0; data < heading.length; data++){
        let tableData = document.createElement("td");
        tableData.appendChild(document.createTextNode(MOUNTAINS[row][heading[data]]));
        tableRow.appendChild(tableData);
    }
    tableHead.appendChild(tableRow);
}

mountainTable.appendChild(tableHead);
placeInHtml.appendChild(mountainTable);
