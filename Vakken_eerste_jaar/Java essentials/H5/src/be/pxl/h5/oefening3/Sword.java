package be.pxl.h5.oefening3;

public class Sword extends Weapon{
    private double sharpness;
    private static final double MIN_SHARPNESS = 0.2;
    private static final double MAX_SHARPNESS = 1.0;


    public Sword(int attackPower){
        super(attackPower);
        sharpness = MAX_SHARPNESS;
    }

    public double doDamage() {
        sharpness -= 0.1;
        if (sharpness < MIN_SHARPNESS){
            sharpness = MIN_SHARPNESS;
        }
        return sharpness * super.doDamage();
    }
}
