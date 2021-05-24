class Person {
    constructor(firstname, lastname, birthString) {
        this.birth = Date.parse(birthString)
        this._firstname = firstname;
        this._lastname = lastname;
    }

    get firstname() {
        return this._firstname;
    }

    set firstname(value) {
        this._firstname = value;
    }

    get lastname() {
        return this._lastname;
    }

    set lastname(value) {
        this._lastname = value;
    }

    get birth() {
        return this._birth;
    }

    set birth(value) {
        this._birth = value;
    }

    getAge(){
        const age = Date.now() - (this.birth);
        let difference = new Date(age).getFullYear() - 1970;
        return difference
    }
    print() {
        console.log(`${this._firstname} ${this._lastname} is ${this.getAge()} years old`);
    }
}
let persoon = new Person('Jane', 'Doe', '08/20/2002')
persoon.print();