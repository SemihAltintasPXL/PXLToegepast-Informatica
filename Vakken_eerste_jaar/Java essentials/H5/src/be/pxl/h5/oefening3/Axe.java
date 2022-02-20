package be.pxl.h5.oefening3;

public class Axe extends Weapon{
    private double sharpness;
    private static final double MIN_SHARPNESS = 0.1;
    private static final double MAX_SHARPNESS = 0.8;


    public Axe(int attackPower){
        super(attackPower);
        sharpness = MAX_SHARPNESS;
    }

    public double doDamage() {
        sharpness -= 0.02;
        if (sharpness < MIN_SHARPNESS){
            sharpness = MIN_SHARPNESS;
        }
        return sharpness * super.doDamage();
    }
}
