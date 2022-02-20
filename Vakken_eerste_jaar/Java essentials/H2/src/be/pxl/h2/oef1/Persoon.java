package be.pxl.h2.oef1;

public class Persoon {
    private String voornaam;
    private String naam;
    private double lengte;
    private double gewicht;
    private int geboortejaar;

    public Persoon(){
        this("onbekend", "onbekend");
    }
    public Persoon(Persoon bestaandepersoon){
        this(bestaandepersoon.naam, bestaandepersoon.voornaam);
    }
    public Persoon(String naam, String voornaam){
        setNaam(naam);
        setVoornaam(voornaam);
    }
    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setLengte(double lengte) {
        if (lengte > 2.40){
            lengte = 2.40;
        }
        this.lengte = lengte;
    }

    public void setGewicht(double gewicht) {
        this.gewicht = gewicht;
    }

    public void setGeboortejaar(int geboortejaar) {
        this.geboortejaar = geboortejaar;
    }

    public String getVoornaam() {
        return voornaam;
    }

    public String getNaam() {
        return naam;
    }

    public double getLengte() {
        return lengte;
    }

    public double getGewicht() {
        return gewicht;
    }

    public int getGeboortejaar() {
        return geboortejaar;
    }

    public int getLeeftijd(){
        return 2021 - getGeboortejaar();
    }
    public void groei(){
        setLengte(lengte + 0.01);
    }
    public void groei(double aantal_cm_gegroeid){
        setLengte(lengte + aantal_cm_gegroeid);
    }

    public String toString(){
        StringBuilder tekst = new StringBuilder(String.format("Deze persoon is %s %s %n", this.voornaam, this.naam));
        tekst.append(String.format("%-15s : %.2f%n", "gewicht", this.gewicht));
        tekst.append(String.format("%-15s : %.2f%n", "lengte", this.lengte));
        tekst.append(String.format("%-15s : %d%n", "geboortejaar", this.geboortejaar));
        return tekst.toString();
    }
    public double berekenBmi(){
        return this.gewicht / (this.lengte * this.lengte);
    }
    public String geefOmschrijving(){
        double bmi = berekenBmi();
        if (bmi < 18){
            return "ondergewicht";
        }
        else if (bmi < 25){
            return "normaal";
        }
        else if (bmi < 30){
            return "overgewicht";

        }
        else if (bmi < 40){
            return "obesitas";

        }
        return "morbide obesitas";
    }
    public void voegVoornamenToe(String[] voornamen){
        StringBuilder stringBuilder = new StringBuilder(this.getVoornaam());

        for (int i = 0; i < voornamen.length; i++){
            stringBuilder.append(voornamen[i]);
            stringBuilder.append(" ");
        }
        this.setVoornaam(stringBuilder.toString());
    }
}
