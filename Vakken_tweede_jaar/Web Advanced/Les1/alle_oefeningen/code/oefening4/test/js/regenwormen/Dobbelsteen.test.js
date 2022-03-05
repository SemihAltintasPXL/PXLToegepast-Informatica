import Dobbelsteen from '../../../src/js/regenwormen/Dobbelsteen';
// naam = Altintas Semih

test('Zijde is gelijk aan 1',
    () => {
        let dobbelsteen = new Dobbelsteen('1');
        let waarde = dobbelsteen.getNumeriekeWaarde()
        expect(waarde).toBe(1);
    });

test('Zijde is gelijk aan 5',
    () => {
        let dobbelsteen = new Dobbelsteen('R');
        let waarde = dobbelsteen.getNumeriekeWaarde()
        expect(waarde).toBe(5);
    });
