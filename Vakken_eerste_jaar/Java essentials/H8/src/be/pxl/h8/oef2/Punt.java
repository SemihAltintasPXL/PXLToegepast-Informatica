package be.pxl.h8.oef2;

public class Punt {
    private int x;
    private int y;
    public static final int MAXIMUMGROOTTE = 99;

    public Punt(int x, int y){
        this.x = x;
        this.y = y;
    }
    public int berekenAfstand(Punt punt2){
        return (int) Math.sqrt((Math.pow(this.x - punt2.getX(), 2) + Math.pow(this.y - punt2.getY(), 2)));

    }
    private void controleer(){
        if (this.x < 0){
            setX(0);
        }
        else if (this.x > MAXIMUMGROOTTE){
            setX(MAXIMUMGROOTTE);
        }
        if (this.y < 0) {
            setY(0);
        }
        else if (this.y > MAXIMUMGROOTTE){
            setY(MAXIMUMGROOTTE);
        }

    }
    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public void setX(int x) {
        this.x = x;
        controleer();
    }

    public void setY(int y) {
        this.y = y;
        controleer();
    }
    @Override
    public String toString(){
        return String.format("[%d, %d]", x, y);
    }
}
