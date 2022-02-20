package be.pxl.h7.oef5;

public class TShirt {
    private TShirtSize maat;
    private Kleur kleur;
    private int aantal = 0;

    public TShirt(TShirtSize size, Kleur kleur){
        setKleur(kleur);
        setMaat(maat);
    }

    public TShirtSize getMaat() {
        return maat;
    }

    public void setMaat(TShirtSize maat) {
        this.maat = maat;
    }

    public Kleur getKleur() {
        return kleur;
    }

    public void setKleur(Kleur kleur) {
        this.kleur = kleur;
    }

    public int getAantal() {
        return aantal;
    }

    public void setAantal(int aantal) {
        this.aantal = aantal;
    }
}
