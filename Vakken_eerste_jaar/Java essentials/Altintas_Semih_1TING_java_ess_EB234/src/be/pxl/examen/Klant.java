package be.pxl.examen;

public class Klant extends Persoon{
    private Adres adres;
    public Klant(String voornaam, String achternaam) {
        super(voornaam, achternaam);
    }

    public Adres getAdres() {
        return adres;
    }

    public void setAdres(Adres adres) {
        this.adres = adres;
    }
}
