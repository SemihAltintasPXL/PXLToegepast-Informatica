class Account {
    constructor(landcode, banknummer, getallen) {
        this.landcode = landcode;
        this.banknummer = banknummer;
        this.getallen = getallen;
    }
    print(){
        let getalReeks1 = ""
        let gettalReeks2 = ""
        let getalReeks3 = "95"
        for (let i = 0; i < 4; i++){
            getalReeks1 += this.getallen[i];
        }
        for (let i = 4; i < 8; i++){
            gettalReeks2 += this.getallen[i];
        }
        console.log(`${this.landcode} ${this.banknummer} ${getalReeks1} ${gettalReeks2} ${getalReeks3}`)
    }
}
acc = new Account('BE', 76, '0012557909');
acc.print()