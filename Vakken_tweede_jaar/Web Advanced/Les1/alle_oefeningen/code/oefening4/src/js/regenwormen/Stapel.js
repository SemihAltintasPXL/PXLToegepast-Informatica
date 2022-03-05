"use strict";
// naam = 
import Dobbelsteen from './Dobbelsteen';
import Selectie from './Selectie';
import {setLevels} from "winston";

let _selecties

export default class Stapel{
    constructor() {
        _selecties = []
    }


    voegSelectieToe(selectie){
        if (!selectie instanceof Selectie){
            throw new Error("Argument is not a type of selectie")
        }
        else if (selectie.getDobbelsteen().getZijde() in _selecties){
            throw new Error("Het zijde zit er al in")
        }
        _selecties.push(selectie)
    }
    getNumeriekeWaarde(){
        let som = 0;
        if (!_selecties.includes('R')){
            return 0
        }
        else{
            for (let s in _selecties){
                som += s;
            }
            return som;
        }
    }
}



