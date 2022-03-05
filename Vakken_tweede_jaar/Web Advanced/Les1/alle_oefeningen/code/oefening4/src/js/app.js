"use strict";
// naam =

import Dobbelsteen from './regenwormen/Dobbelsteen';
import Selectie from './regenwormen/Selectie';
import Stapel from './regenwormen/Stapel';

window.addEventListener('load', (event) => {
    let dobbelsteen1 = new Dobbelsteen('1');
    document.write(dobbelsteen1.getZijde());          //'1'
    document.write(dobbelsteen1.getNumeriekeWaarde()); //1
    try{
        let dobbelsteen2 = new Dobbelsteen('S');
    } catch (error){
        document.write("error1");                      //error1
    }
    let selectie1=new Selectie(3, dobbelsteen1);
    document.write(selectie1.getNumeriekeWaarde());    //3
    try{
        let selectie2 = new Selectie(3,'mis');
    } catch (error){
        document.write("error2");                      //error2
    }
    let stapel = new Stapel();
    stapel.voegSelectieToe(selectie1);
    document.write(stapel.getNumeriekeWaarde());       //0
    let dobbelsteen2 = new Dobbelsteen('R');
    let selectie2=new Selectie(2, dobbelsteen2);
    stapel.voegSelectieToe(selectie2);
    document.write(stapel.getNumeriekeWaarde());       //13
    let selectie3=new Selectie(1, new Dobbelsteen('R'));
    try{
        stapel.voegSelectieToe(selectie3);
    } catch (error){
        document.write("error3");                      //error3
    }

});



