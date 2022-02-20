package be.pxl.h7.oef2.oef5;

public class Tshirt {
    private TShirtSize maat;
    private Kleur kleur;
    private int aantalBesteld;

    public Tshirt(TShirtSize maat, Kleur kleur) {
        this.maat = maat;
        this.kleur = kleur;
    }
    public int getAantalBesteld() {
        return aantalBesteld;
    }

    public void setAantalBesteld(int aantalBesteld) {
        this.aantalBesteld = aantalBesteld;
    }
}
