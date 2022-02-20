package be.pxl.h8.oef2;

public abstract class ZeeObject {
    private Punt locatie;
    private Alliantie alliantie;
    private int levenspunten;

    public ZeeObject(int x, int y, Alliantie alliantie, int levenspunten) {
        this.locatie = new  Punt(x, y);
        this.alliantie = alliantie;
        this.levenspunten = levenspunten;
    }

    public Punt getLocatie() {
        return locatie;
    }

    public Alliantie getAlliantie() {
        return alliantie;
    }

    public int getLevenspunten() {
        return levenspunten;
    }
    public void ontvangSchade(int schade){
        levenspunten -= schade;
    }

    public void setLocatie(Punt locatie) {
        this.locatie = locatie;
    }
    public String toString(){
        return getLocatie().toString() + "\t" + getLevenspunten();
    }
}
