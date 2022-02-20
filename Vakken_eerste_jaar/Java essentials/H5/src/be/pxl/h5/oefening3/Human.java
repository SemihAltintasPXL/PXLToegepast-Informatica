package be.pxl.h5.oefening3;

import java.util.ArrayList;

public abstract class Human extends Character{
    private Weapon weapon;
    private ArrayList<Character>defeatedEnemies;

    public Human(String naam){
        super(naam, 100);
        defeatedEnemies = new ArrayList<Character>();
    }
    public void attack(Character opponent){
        opponent.decreaseHealth(weapon.doDamage());
        if (!opponent.alive()){
            defeatedEnemies.add(opponent);
        }

    }
    public Weapon getWeapon() {
        return weapon;
    }

    public ArrayList<Character> getDefeatedEnemies() {
        return defeatedEnemies;
    }

    public void setWeapon(Weapon weapon) {
        this.weapon = weapon;
    }

}
