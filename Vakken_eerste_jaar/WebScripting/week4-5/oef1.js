let person = {
    firstname : "Lukas",
    lastname : "Gendera",
    birth : new Date(2001,10,4),//hier gaat ook date.parse
    getAge : function (){
        const age = Date.now() - (this.birth);
        let difference = new Date(age).getFullYear() - 1970;
        return difference
        //console.log(`${firstname} ${lastname} is ${difference} years old.`);
    },
    print() {
        console.log(`${this.firstname} ${this.lastname} is ${this.getAge()} years old`)
    }
};
person.print()