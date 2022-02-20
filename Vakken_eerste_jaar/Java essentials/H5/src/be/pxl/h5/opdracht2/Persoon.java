package be.pxl.h5.opdracht2;

public class Persoon {
    private String naam;
    private String voornaam;

    public Persoon() {
        this("Onbekend", "Onbekend");
    }

    public Persoon(String naam, String voornaam) {
        this.naam = naam;
        this.voornaam = voornaam;
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
