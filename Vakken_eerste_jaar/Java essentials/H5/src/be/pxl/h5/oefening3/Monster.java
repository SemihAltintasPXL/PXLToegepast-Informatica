package be.pxl.h5.oefening3;

public class Monster extends Character{
    private double attackPower;

    public Monster(String naam, double attackPower){
        super(naam, 50);
        this.attackPower = attackPower;
    }
    public void attack(Character opponent){
        opponent.decreaseHealth(attackPower);
    }
    public String toString(){
        return getName();
    }
}
