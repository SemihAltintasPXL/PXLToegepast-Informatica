package be.pxl.h5.oefening3;

public class Warrior extends Human{
    private Sword sword;
    //deze bolt ook niet perfect en weet niet welke wapen hij vast heeft
    public Warrior(String name){
        super(name);
        setWeapon(new Sword(10));

    }

    public void attack(Character opponent) {
        opponent.decreaseHealth(sword.doDamage());
        speak("Attacking " + opponent.getName() + " with my sword!");
    }

    public void setWeapon(Weapon weapon) {
        if (!(weapon instanceof Sword) && !(weapon instanceof Axe)){
            speak("I only know how to swing swords and axes!");
        }
    }

}
