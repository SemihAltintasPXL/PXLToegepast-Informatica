package be.pxl.h2.opdracht3;

public class Klasgroep {
    public static final int MAXIMUM_AANTAL_STUDENTEN = 40;
    private static int teller = 0;
    private static int totaalAantalStudenten = 0;
    private String naam;
    private int aantalStudenten;

    public Klasgroep() {
        this("1TINx", 0);
    }

    public Klasgroep(String naam, int aantalStudenten) {
        this.naam = naam;
        setAantalStudenten(aantalStudenten);
        teller++;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getAantalStudenten() {
        return aantalStudenten;
    }

    public void setAantalStudenten(int aantalStudenten) {
        if(aantalStudenten > MAXIMUM_AANTAL_STUDENTEN) {
            aantalStudenten = MAXIMUM_AANTAL_STUDENTEN;
        }

        totaalAantalStudenten -= this.aantalStudenten;
        this.aantalStudenten = aantalStudenten;
        totaalAantalStudenten += this.aantalStudenten;
    }

    public static int getTeller() {
        return teller;
    }

    public static int getTotaalAantalStudenten() {
        return totaalAantalStudenten;
    }
}
