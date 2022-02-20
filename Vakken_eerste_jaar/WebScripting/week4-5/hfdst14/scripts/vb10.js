'use strict'
let para = document.body.getElementsByTagName("p")[0];
let clientRect = para.getBoundingClientRect();
console.log(clientRect.height);