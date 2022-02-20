package be.pxl.h5.oefening3;

public abstract class Character {
    private String name;
    private double health;

    public Character(String name, double health){
        this.name = name;
        this.health = health;
    }
    public boolean alive(){
        if (this.health <= 0){
            return false;
        }
        return true;
    }

    public abstract void attack(Character opponent);

    public double decreaseHealth(double damage){
        this.health -= damage;
        if (this.health <= 0){
            System.out.println(getName() + " is dead");
        }
        return this.health;
    }

    public String getName() {
        return name;
    }

    public double getHealth() {
        return health;
    }

    public double heal(double additionalHealth){
        this.health += additionalHealth;
        if (this.health > 100){
            this.health = 100;
            System.out.println(name + " Feeling Great!");
        }
        return this.health;
    }
    public void speak(String text){
        System.out.println(getName() + ": " + text);
    }

}
