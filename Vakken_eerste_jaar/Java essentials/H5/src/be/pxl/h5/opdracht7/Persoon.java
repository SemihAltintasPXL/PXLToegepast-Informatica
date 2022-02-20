package be.pxl.h5.opdracht7;

public class Persoon {
    private static int aantal = 0;
    private String naam;
    private String voornaam;

    public Persoon() {
        this("Onbekend", "Onbekend");
    }

    public Persoon(String naam, String voornaam) {
        this.naam = naam;
        this.voornaam = voornaam;
        aantal++;
    }

    public static int getAantal() {
        return aantal;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getVoornaam() {
        return voornaam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public void print() {
        System.out.println("Naam: " + voornaam + " " + naam);
    }
}
