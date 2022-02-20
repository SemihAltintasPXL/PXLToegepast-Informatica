package be.pxl.extra.project3;

public abstract class Spel {
    private String naam;
    private int minimumLeeftijd;
    private Uitgever uitgever;

    public Spel(String naam, Uitgever uitgever) {
        this.naam = naam;
        this.uitgever = uitgever;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getMinimumLeeftijd() {
        return minimumLeeftijd;
    }

    public void setMinimumLeeftijd(int minimumLeeftijd) {
        if (minimumLeeftijd < 0){
            this.minimumLeeftijd = 12;
        }else{
            this.minimumLeeftijd = minimumLeeftijd;
        }
    }

    public Uitgever getUitgever() {
        return uitgever;
    }
    public String toString(){
        return uitgever.toString();
    }
}
