class Account{
    constructor(landcode, banknummer, uniek) {
        this.landcode = landcode;
        this.banknummer = banknummer;
        this.uniek = uniek;
    }

    print(){
        let controle = this.uniek % 97;
        console.log(`${this.landcode} ${this.banknummer} ${this.uniek.slice(0,4)} ${this.uniek.slice(4,8)} ${this.uniek.slice(8)}${controle}`);//slice gaat ook door .substr
        //slice is gewoon substring
    }
}

let account1 = new Account("BE", "76", "0012557909");
account1.print();