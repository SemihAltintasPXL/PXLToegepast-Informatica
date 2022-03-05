import Dobbelsteen from '../../../src/js/regenwormen/Dobbelsteen';
import Selectie from '../../../src/js/regenwormen/Selectie';
import Stapel from '../../../src/js/regenwormen/Stapel';
// naam = Altintas Semih


let dobbelsteen1 = new Dobbelsteen('1');
//let dobbelsteen2 = new Dobbelsteen('1');
let selectie1 = new Selectie(2, dobbelsteen1);
//let selectie2 = new Selectie(3, dobbelsteen1);
let stapel = new Stapel();

test('should throw an Error given an invalid argument',
    () => {
        expect(() => {
            stapel.voegSelectieToe(selectie1)
            //stapel.voegSelectiesToe(selectie2)
        }).toThrow(Error)
    });

test('getNumeriekeWaarde moet juiste waarde 0 hebben',
    () => {
        let dobbelsteen1 = new Dobbelsteen('1');
        let dobbelsteen2 = new Dobbelsteen('2')
        let selectie1 = new Selectie(3, dobbelsteen1)
        let selectie2 = new Selectie(2, dobbelsteen2)
        let stapel = new Stapel();
        stapel.voegSelectieToe(selectie1)
        stapel.voegSelectieToe(selectie2)
        let waarde = stapel.getNumeriekeWaarde()
        expect(waarde).toBe(0);
    });




