class Person {
    constructor(voornaam, naam, geboortedatum) {
        this.voornaam = voornaam;
        this.naam = naam;
        this.geboortedatum = new Date(geboortedatum)
    }

    set naam (naam){
        this._naam = naam;
    }

    get naam (){
        return this._naam;
    }

    set voornaam (voornaam){
        this._voornaam = voornaam;
    }

    get voornaam (){
        return this._voornaam;
    }

    set geboortedatum (geboortedatum){
        this._geboortedatum = geboortedatum;
    }

    get geboortedatum (){
        return this._geboortedatum;
    }

    get ouderdom (){
        let leeftijd
        let datum = new Date(Date.now());
        if (this._geboortedatum.getMonth() >= datum.getMonth() && this._geboortedatum.getDate() >= datum.getDate()){
            leeftijd = datum.getFullYear() - this._geboortedatum.getFullYear() - 1;
        } else {
            leeftijd = datum.getFullYear() - this._geboortedatum.getFullYear();
        }
        return leeftijd
    }

    print (){
        console.log(`naam: ${this._voornaam} ${this._naam} leeftijd ${this.ouderdom}`)
    }
}

persoon = new Person('Milan', 'Gysen', 'December 23, 2001')
persoon.print()
