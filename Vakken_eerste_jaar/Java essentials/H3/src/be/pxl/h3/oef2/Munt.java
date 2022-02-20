package be.pxl.h3.oef2;

public class Munt {
    private String naam;
    private double koers;
    private static final int AFRONDING = 3;
    private static int aantal = 0;

    public Munt(){
        this("euro", 1);
    }
    public Munt(String nm, double k){
        setNaam(nm);
        setKoers(k);
        aantal++;
    }

    public String getNaam() {
        return naam.toUpperCase();
    }
    public void setNaam(String naam) {
        this.naam = naam;
    }

    public double getKoers() {
        return koers;
    }
    public void setKoers(double koers) {
        this.koers = Math.round(koers * Math.pow(10, AFRONDING)) / Math.pow(10, AFRONDING);
    }
    public static int getAantal() {
        return aantal;
    }
    public static int getAfronding() {
        return AFRONDING;
    }
}
