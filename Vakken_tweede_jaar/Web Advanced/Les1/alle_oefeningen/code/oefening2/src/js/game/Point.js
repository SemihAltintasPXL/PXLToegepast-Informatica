"use strict";

export default class Point{
    constructor(x,y){
        if (typeof x != 'number' || typeof y !='number') {
            throw new Error("Parameter is not a number!");
        }
        this._x=x;
        this._y=y;
    }

    get x(){
        return this._x;
    }
    get y(){
        return this._y;
    }

    toString() {
        return `(${this._x},${this._y})`;
    }
}


