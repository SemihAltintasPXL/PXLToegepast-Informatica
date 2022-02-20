package be.pxl.h2.opdracht1;

import java.time.Period;

public class Auto {
    private String kleur;
    private String merk;
    private int kilometerStand;
    private int aantalDeuren;
    private boolean automaat;

    public Auto() {

    }

    public Auto(String kleur, String merk, int aantalDeuren) {
        this(kleur, merk, aantalDeuren, 0);
    }

    public Auto(String kleur, String merk, int aantalDeuren, int kilometerStand) {
        this.kleur = kleur;
        this.merk = merk;
        this.aantalDeuren = aantalDeuren;
        setKilometerStand(kilometerStand);
    }

    // Copy constructor
    public Auto(Auto andere) {
        this(andere.kleur, andere.merk, andere.aantalDeuren, andere.kilometerStand);
        this.automaat = andere.getAutomaat();
    }

    public double getPrijs() {
        double prijs = 20000;

        if(aantalDeuren == 5) {
            prijs += 2000;
        } else if(aantalDeuren == 3) {
            prijs -= 500;
        }

        if(automaat) {
            prijs += 2000;
        } else {
            prijs *= 0.98;
        }

        return prijs;
    }

    public boolean getAutomaat() {
        return automaat;
    }

    public void setAutomaat(boolean automaat) {
        this.automaat = automaat;
    }

    public String getKleur() {
        return kleur;
    }

    public String getMerk() {
        return merk;
    }

    public int getKilometerStand() {
        return kilometerStand;
    }

    public int getAantalDeuren() {
        return aantalDeuren;
    }

    public void setKleur(String kleur) {
        this.kleur = kleur;
    }

    public void setMerk(String merk) {
        this.merk = merk;
    }

    public void setKilometerStand(int kilometerStand) {
        if(kilometerStand < 0) {
            kilometerStand *= -1;
        }
        this.kilometerStand = kilometerStand;
    }

    public void setAantalDeuren(int aantalDeuren) {
        this.aantalDeuren = aantalDeuren;
    }

}
