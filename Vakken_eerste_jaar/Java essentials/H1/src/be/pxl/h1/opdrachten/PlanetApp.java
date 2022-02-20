package be.pxl.h1.opdrachten;

public class PlanetApp {
    private String name;
    private int diameter;
    private long distanceFromSun;

    public String getName() {
        return name;
    }

    public int getDiameter() {
        return diameter;
    }

    public long getDistanceFromSun() {
        return distanceFromSun;
    }

    public void setDistanceFromSun(long distanceFromSun) {
        this.distanceFromSun = distanceFromSun;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setDiameter(int diameter) {
        this.diameter = diameter;
    }
}
