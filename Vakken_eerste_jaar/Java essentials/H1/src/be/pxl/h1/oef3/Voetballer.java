package be.pxl.h1.oef3;

import java.util.Locale;

public class Voetballer {
    private String naam;
    private int leeftijd;
    private int beoordeling;
    private String type;
    private int aantal_doelpunten;

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getLeeftijd() {
        return leeftijd;
    }

    public void setLeeftijd(int leeftijd) {
        this.leeftijd = leeftijd;
    }

    public int getBeoordeling() {
        return beoordeling;
    }

    public void setBeoordeling(int beoordeling) {
        this.beoordeling = beoordeling;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public int getAantal_doelpunten() {
        return aantal_doelpunten;
    }

    public void setAantal_doelpunten(int aantal_doelpunten) {
        this.aantal_doelpunten = aantal_doelpunten;
    }

    public double berekenPrijs(){
        double basisprijs;
        if (type.equals("aanvaller")){
            basisprijs = 30000;
        }
        else if (type.equals("middenvelder")){
            basisprijs = 28000;
        }
        else if (type.equals("verdediger")){
            basisprijs = 28000;
        }
        else {
            basisprijs = 25000;
        }
        if (leeftijd < 25){
            basisprijs *= 1.10;
        }
        else if (leeftijd > 30){
            basisprijs *= 0.95;
        }
        if (type.equals("aanvaller")){
            if (aantal_doelpunten < 5){
                basisprijs += aantal_doelpunten * 10000;
            }
            else {
                basisprijs = basisprijs +  10000 * 5 + (aantal_doelpunten - 5) * 20000;
            }
        } else{
            basisprijs = basisprijs +  (10000 * beoordeling);
        }
        if (type.equals("doelman") && (aantal_doelpunten > 20)) {
            basisprijs = basisprijs - 9000;
        }
        return basisprijs;
    }

}
