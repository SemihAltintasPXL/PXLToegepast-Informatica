package be.pxl.h5.opdracht8en9;

public class Cirkel extends GrafischElement {

    private double straal;

    public Cirkel(int x, int y, double straal) {
        super(x,y);
        this.straal = straal;
    }

    public double getStraal() {
        return straal;
    }

    public void setStraal(double straal) {
        this.straal = straal;
    }

    @Override
    public String toString() {
        return "Cirkel met straal " + straal + " @" + super.toString();
    }

    @Override
    public double getOmtrek() {
        return 2 * Math.PI * straal;
    }

    @Override
    public double getOppervlakte() {
        return Math.PI * straal * straal; // Math.pow(straal, 2)
    }
}
