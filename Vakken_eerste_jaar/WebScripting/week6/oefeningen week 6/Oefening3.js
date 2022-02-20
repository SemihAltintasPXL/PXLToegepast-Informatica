'use district'
console.log('oefening 3')
window.addEventListener('load', handleLoad);

function handleLoad(){
    let buttonAllPerformances = document.getElementsByTagName('button')[0];
    buttonAllPerformances.addEventListener('click', AllPerformancesClicked);
    let buttonDatePerformances = document.getElementsByTagName('button')[1];
    buttonDatePerformances.addEventListener('click', DatePreformancesClicked);
    let buttonPreformanceId = document.getElementsByTagName('button')[2];
    buttonPreformanceId.addEventListener('click', PreformanceIdClicked);
    let buttonPostPerformance = document.getElementsByTagName('button')[3];
    buttonPostPerformance.addEventListener('click', PostPerformance);
}

function AllPerformancesClicked(){
    let url = 'http://localhost:3000/performances';
    let output = document.querySelector('output');
    makeElementEmpty(output);
    fetch(url)
        .then((response) => {
            if (response.status === 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((preformances) => {
            let data = [];
            for (let preformance of preformances) {
                data.push([preformance.id, preformance.name, preformance.play_date, preformance.description]);
            }
            let table = makeTable(data);
            output.appendChild(table);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
}

function DatePreformancesClicked(){
    let url = 'http://localhost:3000/performances';
    let output = document.querySelector('output');
    let date = document.getElementsByTagName('input')[0].value;
    makeElementEmpty(output);
    fetch(url)
        .then((response) => {
            if (response.status === 200){
                return response.json();
            } else {
                throw `error with status ${response.status}`
            }
        })
        .then((preformances) => {
            let data = [];
            for (let preformance of preformances){
                if (preformance.play_date == date){
                    data.push([preformance.id, preformance.name, preformance.play_date, preformance.description]);
                }
            }
            let table = makeTable(data);
            output.appendChild(table);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
}

function PreformanceIdClicked(){
    let url = 'http://localhost:3000/performances/'
    let id = document.getElementsByTagName('input')[1].value;
    let output = document.querySelector('output');
    makeElementEmpty(output);
    if(id.trim()!=''){
        fetch(url + id)
            .then((response) => {
                if (response.status === 200) {
                    return response.json();
                } else {
                    throw `error with status ${response.status}`;
                }
            })
            .then((preformance) => {
                let data = [];
                data.push([preformance.id, preformance.name, preformance.play_date, preformance.description]);
                let table = makeTable(data);
                output.appendChild(table);
            })
            .catch((error) => {
                output.appendChild(document.createTextNode(error));
            });
    }
}

function PostPerformance(){
    let url = 'http://localhost:3000/performances/';
    let output = document.querySelector('output');
    let name = document.getElementsByTagName('input')[2].value;
    let date = document.getElementsByTagName('input')[3].value;
    let description = document.getElementsByTagName('input')[4].value;
    let preformance = {name: name, play_date: date, description: description };
    makeElementEmpty(output);
    fetch(url,
        {
            method: "POST",
            body: JSON.stringify(preformance),
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
        .then((preformance) => {
            let data = [];
            data.push([preformance.id, preformance.name, preformance.play_date, preformance.description]);
            let table = makeTable(data);
            output.appendChild(table);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });
}

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
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