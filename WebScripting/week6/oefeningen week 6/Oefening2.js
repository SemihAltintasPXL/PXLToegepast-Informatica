'use strict';
console.log('start script');
window.addEventListener('load',handleLoad);

function handleLoad() {
    //select maken met data via fetch opgehaald
    let url = 'http://localhost:3000/persons/';
    let output = document.querySelector('output');
    let select = document.createElement('select');
    fetch(url)
        .then((resonse) => {
            if (resonse.status === 200){
                return resonse.json();
            } else {
                throw `error with status ${resonse.status}`;
            }
        })
        .then((persons) =>{
            //let data = [];
            //for (let person of persons){
            //    data.push(person.name);
            //}
            for (let i = 0; i < persons.length; i++){
                let option = document.createElement('option');
                option.appendChild(document.createTextNode(persons[i].name));
                option.setAttribute('value', persons[i].id);
                select.appendChild(option);
                let output = document.querySelector('output');
                output.appendChild(select);
            }
            let ZoekVriendenButton = document.getElementById('ZoekButton');
            ZoekVriendenButton.addEventListener('click', handleZoek);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
    let PutButton = document.getElementById('PutButton');
    PutButton.addEventListener('click', handlePut);
}

function handleZoek(){
    let url = 'http://localhost:3000/persons/';
    let select = document.querySelector('select').value;
    let output = document.getElementById('output2');
    makeElementEmpty(output);
    fetch(url + select)
        .then((response) => {
            if (response.status === 200){
                return response.json();
            } else {
                throw `error with code ${response.status}`
            }
        })
        .then((person ) => {
            if (person.friends.length > 0){
                let friendsString = (person.friends).join('&id=');
                console.log(`${url}?id=${friendsString}`);
                fetch(`${url}?id=${friendsString}`)
                    .then((response) => {
                        if (response.status === 200){
                            return response.json();
                        } else {
                            throw `error with code ${response.status}`
                        }
                    })
                    .then((friends) =>{
                        let text ='';
                        for (let friend of friends){
                            text += ` ${friend.name},`
                        }
                        output.appendChild(document.createTextNode(`${person.name} heeft de volgende vrienden ${text}`));
                    })
            } else {
                output.appendChild(document.createTextNode(`${person.name} heeft geen vrienden!`))
            }
            
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
}

function handlePut(){
    let url = 'http://localhost:3000/persons/';
    let output = document.getElementById('output2');
    let name = document.getElementById("txt_name").value;
    let person = {name: name, friends:[]};
    fetch(url,
        {
            method: "POST",
            body: JSON.stringify(person),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
        .then((response) => {
            if (response.status === 201) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((person) => {
            let data = [];
            data.push([person.id, person.name]);
            let table = makeTable(data);
            output.appendChild(table);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
}

function makeTable(matrix) {
    let table = document.createElement("table");
    for (let i = 0; i < matrix.length; i++) {
        let tr = document.createElement("tr");
        for (let j = 0; j < matrix[i].length; j++) {
            let td = document.createElement("td");
            td.appendChild(document.createTextNode(matrix[i][j]));
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
    return table;
}

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}