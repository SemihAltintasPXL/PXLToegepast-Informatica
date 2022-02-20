package be.pxl.h5.oefening3;

public abstract class Weapon {
    private int attackPower;

    public Weapon(int attackPower){
        this.attackPower = attackPower;
    }
    public double doDamage(){
        return this.attackPower;
    }
}
