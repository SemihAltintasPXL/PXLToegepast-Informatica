class Account{
    constructor(landcode, banknummer, uniek, saldo) {
        this.landcode = landcode;
        this.banknummer = banknummer;
        this.uniek = uniek;
        this.saldo = saldo;
    }

    stortGeld(geld){
        this.saldo += geld;
    }

    verwijderGeld(geld){
        this.saldo -= geld;
    }

    print(){
        let controle = this.uniek % 97;
        console.log(`Rekeningnummer: ${this.landcode}${this.banknummer}${this.uniek}${controle}`);
        console.log(`Saldo: €${this.saldo}`)
    }
}

let account1 = new Account("BE", "76", "0012557909", 400);
account1.stortGeld(10);
account1.verwijderGeld(5);
account1.print();