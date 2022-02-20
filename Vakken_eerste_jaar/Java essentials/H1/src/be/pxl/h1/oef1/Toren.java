package be.pxl.h1.oef1;

public class Toren {
    private String naam;
    private String locatie;
    private int jaarVoltooid;
    private int hoogte;
    private int aantalVerdiepingen;

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setLocatie(String locatie) {
        this.locatie = locatie;
    }

    public void setJaarVoltooid(int jaarVoltooid) {
        this.jaarVoltooid = jaarVoltooid;
    }

    public void setHoogte(int hoogte) {
        this.hoogte = hoogte;
    }

    public void setAantalVerdiepingen(int aantalVerdiepingen) {
        this.aantalVerdiepingen = aantalVerdiepingen;
    }

    public String getNaam() {
        return naam;
    }

    public String getLocatie() {
        return locatie;
    }

    public int getJaarVoltooid() {
        return jaarVoltooid;
    }

    public int getHoogte() {
        return hoogte;
    }

    public int getAantalVerdiepingen() {
        return aantalVerdiepingen;
    }
}
