package be.pxl.h1.oef5;

public class Spaceship {
    private String name;
    private int hits;
    private boolean shieldOn;


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isShieldOn() {
        return shieldOn;
    }

    public void setShieldOn(boolean shieldOn) {
        if (shieldOn){
            System.out.println(name + " puts shield on");
        }
        this.shieldOn = shieldOn;
    }
    public void fire(Spaceship spaceship){
        System.out.println(this.name + " fires at " + spaceship.name);
        if (isShieldOn()){
            this.hits++;
        }
        else {
            spaceship.hits++;
        }
    }
    public boolean isDestroyed(){
        return hits <= 5;
    }
}
