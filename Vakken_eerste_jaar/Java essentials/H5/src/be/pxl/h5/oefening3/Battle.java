package be.pxl.h5.oefening3;

import java.util.ArrayList;

public class Battle {

    public static void main(String[] args) {

        Warrior gimli = new Warrior("Gimli");
        gimli.setWeapon(new Axe(70));
        Warrior aragorn = new Warrior("Aragorn");
        Archer legolas = new Archer("Legolas");
        legolas.setWeapon(new Sword(60));

        ArrayList<Human> fellowship = new ArrayList<>();
        fellowship.add(legolas);
        fellowship.add(aragorn);
        fellowship.add(gimli);

        legolas.findArrows();

        ArrayList<Monster> monsters = new ArrayList<>();
        monsters.add(new Monster("Orc", 10));
        monsters.add(new Monster("Orc", 10));
        monsters.add(new Monster("Orc", 10));
        monsters.add(new Monster("Orc", 10));
        monsters.add(new Monster("Orc", 10));
        monsters.add(new Monster("Uruk", 20));
        monsters.add(new Monster("Uruk", 20));
        monsters.add(new Monster("Warg", 30));

        for(int i=0;i<3;i++) {
            for(Human human:fellowship) {
                human.attack(monsters.get((int) Math.floor(Math.random()*monsters.size())));
            }

            for(int m=0;m<5;m++) {
                Monster monster = monsters.get((int) Math.floor(Math.random()*monsters.size()));
                if(monster.alive()) {
                    Human target = fellowship.get((int) Math.floor(Math.random()*fellowship.size()));
                    monster.attack(target);
                }
            }

            for(Human human:fellowship) {
                if(human.alive()) {
                    human.heal((int)(Math.random()*40));
                }
            }
        }

        // TODO: Print van elke held zijn verslagen vijanden af
    }
}
