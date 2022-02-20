package be.pxl.h7.oef1;

import java.security.PublicKey;
import java.util.Locale;

public abstract class Bestand implements Uitvoerbaar{
    private String naam;
    private String inhoud;
    private int bestandsGrootte;

    public Bestand(String inhoud){
        setInhoud(inhoud);
    }
    public Bestand(String naam, int bestandsGrootte){
        setNaam(naam);
        setBestandsGrootte(bestandsGrootte);
    }

    public String getNaam() {
        return naam;
    }

    public String getInhoud() {
        return inhoud;
    }

    public int getBestandsGrootte() {
        return bestandsGrootte;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setInhoud(String inhoud) {
        this.inhoud = inhoud;
    }

    public void setBestandsGrootte(int bestandsGrootte) {
        this.bestandsGrootte = bestandsGrootte;
    }

    public String toString(){
        return naam.toUpperCase() + "\t" + bestandsGrootte + "bytes";
    }
}
