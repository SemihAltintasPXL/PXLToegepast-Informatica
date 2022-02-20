let person = {
    _naam : 'Gysen',
    _voornaam : 'Milan',
    _geboortedatum : new Date('December 23, 2001'),
    getLeeftijd : function (){
        datum = new Date(Date.now());
        if (this._geboortedatum.getMonth() >= datum.getMonth() && this._geboortedatum.getDate() >= datum.getDate()){
            leeftijd = datum.getFullYear() - this._geboortedatum.getFullYear() - 1;
        } else {
            leeftijd = datum.getFullYear() - this._geboortedatum.getFullYear();
        }
        return leeftijd;
    },
    print : function (){
        console.log(`name: ${this._naam} ${this._voornaam} age: ${person.getLeeftijd()}`);
    }
}
person.print();