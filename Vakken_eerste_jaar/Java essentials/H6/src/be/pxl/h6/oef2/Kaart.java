package be.pxl.h6.oef2;

public class Kaart {
    private Ranking waarde;
    private Soort soort;

    public Kaart(Ranking r, Soort s){
        setWaarde(r);
        setSoort(s);
    }

    public Ranking getWaarde() {
        return waarde;
    }

    public void setWaarde(Ranking waarde) {
        this.waarde = waarde;
    }

    public Soort getSoort() {
        return soort;
    }

    public void setSoort(Soort soort) {
        this.soort = soort;
    }
    public String toString(){
        return soort.name().substring(0,1).toUpperCase() + soort.name().substring(1).toLowerCase() + " " + waarde.name().toLowerCase();
    }
}
