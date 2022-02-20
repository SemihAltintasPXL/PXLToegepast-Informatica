package be.pxl.h5.oefening3;

public class Bow extends Weapon{
    private int numArrows;

    public Bow(int attackPower, int numArrows){
        super(attackPower);
        this.numArrows = numArrows;
    }
    public double doDamage(){

        if (numArrows <= 0){
            System.out.println("Out of arrows");
            return 0;
        }
        numArrows -= 1;
        return super.doDamage();
    }
    public void addArrows(int numArrowsFound){
        this.numArrows += numArrowsFound;
    }
    public int getNumArrows() {
        return numArrows;
    }
}
