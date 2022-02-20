package be.pxl.h5.oefening1;

public class Persoon {
    private String naam;
    private String voornaam;

    public Persoon(String naam, String voornaam){
        setNaam(naam);
        setVoornaam(voornaam);
    }

    public String getNaam() {
        return naam;
    }

    public String getVoornaam() {
        return voornaam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }
    public void print(){
        System.out.println(voornaam + " " + naam);
    }
}
