"use strict";
// naam = 

export default class Dobbelsteen{
    constructor(zijde) {
        if (zijde >= 1 || zijde <= 5 || zijde === "R"){
            this._zijde = zijde;
        }
        else {
            throw new Error("zijde is niet gelijk aan 1, 2, 3, 4, 5 of R");
        }
        this._zijde = zijde;
    }


    getZijde() {
        return this._zijde;
    }
    getNumeriekeWaarde(){
        if (this.getZijde() === '1'){
            this._zijde = 1
        }
        if (this.getZijde() === '2'){
            this._zijde = 2
        }
        if (this.getZijde() === '3'){
            this._zijde = 3
        }
        if (this.getZijde() === '4'){
            this._zijde = 4
        }
        if (this.getZijde() === '5' || this.getZijde() === 'R'){
            this._zijde = 5
        }
        return this._zijde;
    }
}
