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
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

eval("__webpack_require__.r(__webpack_exports__);\n/* harmony import */ var _game_WereldObject__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./game/WereldObject */ \"./src/js/game/WereldObject.js\");\n/* harmony import */ var _game_Point__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./game/Point */ \"./src/js/game/Point.js\");\n\n\nvar point = new _game_WereldObject__WEBPACK_IMPORTED_MODULE_0__[\"default\"](new _game_Point__WEBPACK_IMPORTED_MODULE_1__[\"default\"](1, 2));\nvar preElement = document.createElement(\"pre\");\nvar textNode = document.createTextNode(\"x = \" + point.X + \"y = \" + point.Y + \"\\n\");\npreElement.appendChild(textNode);\ndocument.getElementById('output').appendChild(preElement);\nconsole.log(point);\n/*\r\nlet point=new Point(1,2);\r\n\r\n*/\n\nconsole.log(\"test\");\n\n//# sourceURL=webpack://oefening2/./src/js/app.js?");

/***/ }),

/***/ "./src/js/game/Point.js":
/*!******************************!*\
  !*** ./src/js/game/Point.js ***!
  \******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   \"default\": () => (/* binding */ Point)\n/* harmony export */ });\n\n\nfunction _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError(\"Cannot call a class as a function\"); } }\n\nfunction _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if (\"value\" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }\n\nfunction _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); Object.defineProperty(Constructor, \"prototype\", { writable: false }); return Constructor; }\n\nvar Point = /*#__PURE__*/function () {\n  function Point(x, y) {\n    _classCallCheck(this, Point);\n\n    if (typeof x != 'number' || typeof y != 'number') {\n      throw new Error(\"Parameter is not a number!\");\n    }\n\n    this._x = x;\n    this._y = y;\n  }\n\n  _createClass(Point, [{\n    key: \"x\",\n    get: function get() {\n      return this._x;\n    }\n  }, {\n    key: \"y\",\n    get: function get() {\n      return this._y;\n    }\n  }, {\n    key: \"toString\",\n    value: function toString() {\n      return \"(\".concat(this._x, \",\").concat(this._y, \")\");\n    }\n  }]);\n\n  return Point;\n}();\n\n\n\n//# sourceURL=webpack://oefening2/./src/js/game/Point.js?");

/***/ }),

/***/ "./src/js/game/WereldObject.js":
/*!*************************************!*\
  !*** ./src/js/game/WereldObject.js ***!
  \*************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   \"default\": () => (/* binding */ WereldObject)\n/* harmony export */ });\n/* harmony import */ var _Point__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./Point */ \"./src/js/game/Point.js\");\n\n\nfunction _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError(\"Cannot call a class as a function\"); } }\n\nfunction _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if (\"value\" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }\n\nfunction _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); Object.defineProperty(Constructor, \"prototype\", { writable: false }); return Constructor; }\n\n\n\nvar WereldObject = /*#__PURE__*/function () {\n  function WereldObject(location) {\n    _classCallCheck(this, WereldObject);\n\n    this._location = location;\n  }\n\n  _createClass(WereldObject, [{\n    key: \"X\",\n    get: function get() {\n      return this._X;\n    },\n    set: function set(value) {\n      this._X = value;\n    }\n  }, {\n    key: \"Y\",\n    get: function get() {\n      return this._Y;\n    },\n    set: function set(value) {\n      this._Y = value;\n    }\n  }]);\n\n  return WereldObject;\n}();\n\n\n\n//# sourceURL=webpack://oefening2/./src/js/game/WereldObject.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = __webpack_require__("./src/js/app.js");
/******/ 	
/******/ })()
;