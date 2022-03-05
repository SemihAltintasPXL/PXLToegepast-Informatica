/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./src/js/app.js":
/*!***********************!*\
  !*** ./src/js/app.js ***!
  \***********************/
/***/ (() => {

eval(" // naam =\n\n/*\nimport Dobbelsteen from './regenwormen/Dobbelsteen';\nimport Selectie from './regenwormen/Selectie';\nimport Stapel from './regenwormen/Stapel';\n\nwindow.addEventListener('load', (event) => {\n    let dobbelsteen1 = new Dobbelsteen('1');\n    document.write(dobbelsteen1.getZijde());          //'1'\n    document.write(dobbelsteen1.getNumeriekeWaarde()); //1\n    try{\n        let dobbelsteen2 = new Dobbelsteen('S');\n    } catch (error){\n        document.write(\"error1\");                      //error1\n    }\n    let selectie1=new Selectie(3, dobbelsteen1);\n    document.write(selectie1.getNumeriekeWaarde());    //3\n    try{\n        let selectie2 = new Selectie(3,'mis');\n    } catch (error){\n        document.write(\"error2\");                      //error2\n    }\n    let stapel = new Stapel();\n    stapel.voegSelectieToe(selectie1);\n    document.write(stapel.getNumeriekeWaarde());       //0\n    let dobbelsteen2 = new Dobbelsteen('R');\n    let selectie2=new Selectie(2, dobbelsteen2);\n    stapel.voegSelectieToe(selectie2);\n    document.write(stapel.getNumeriekeWaarde());       //13\n    let selectie3=new Selectie(1, new Dobbelsteen('R'));\n    try{\n        stapel.voegSelectieToe(selectie3);\n    } catch (error){\n        document.write(\"error3\");                      //error3\n    }\n\n});\n\n\n\n */\n\n//# sourceURL=webpack://oefening4/./src/js/app.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = {};
/******/ 	__webpack_modules__["./src/js/app.js"]();
/******/ 	
/******/ })()
;