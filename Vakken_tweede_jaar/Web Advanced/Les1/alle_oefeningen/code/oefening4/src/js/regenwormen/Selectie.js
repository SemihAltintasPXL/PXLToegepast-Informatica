"use strict";
// naam = 
import Dobbelsteen from './Dobbelsteen';

export default class Dobbelsteen{
    constructor(aantal, dobbelsteen) {
        if (!(dobbelsteen instanceof Dobbelsteen)){
            throw new Error("Het is geen dobbbelsteen")
        }
        this._dobbelsteen = dobbelsteen;
        this._aantal = aantal;
    }

    getAantal() {
        return this._aantal;
    }

    getDobbelsteen() {
        return this._dobbelsteen;
    }
    getNumeriekeWaarde(){
        return this._aantal * this._dobbelsteen.getNumeriekeWaarde();
    }
}
