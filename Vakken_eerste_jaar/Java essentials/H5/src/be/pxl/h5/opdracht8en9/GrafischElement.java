package be.pxl.h5.opdracht8en9;

public abstract class GrafischElement {

    private static int aantal;
    private int x;
    private int y;

    public GrafischElement(int x, int y) {
        this.x = x;
        this.y = y;
        aantal++;
    }

    public static int getAantal() {
        return aantal;
    }

    public void setPositie(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    @Override
    public String toString() {
        return String.format("(%d,%d)", x, y);
    }

    public abstract double getOmtrek();
    public abstract double getOppervlakte();
}
