import Datum from "../../../src/js/accounting/Datum";

test('toString to return the correct value',
    () => {
        let date = new Datum(1, 2, 2010);
        let output = date.toString();
        expect(output).toBe("1/2/2010");
    });

test('toStringMonth to return the correct value',
    () => {
        let date = new Datum(1, 2, 2010);
        let output = date.toStringMonth();
        expect(output).toBe("1/feb/2010");
    });