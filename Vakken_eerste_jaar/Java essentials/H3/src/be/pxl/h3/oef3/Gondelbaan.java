package be.pxl.h3.oef3;

import javax.print.DocFlavor;

public class Gondelbaan {
    private String naam;
    private String land;
    private int hoogteDalstation;
    private int hoogteBergstation;
    private double lengte;
    private double snelheid;
    private int passagiersPerGondel;
    private int aantalGondels;
    private static String[] landen = {"Frankrijk", "Oostenrijk", "Zwitserland", "Italië"};

    public Gondelbaan (String naam, String land, double lengte, double snelheid){
        setNaam(naam);
        setLand(land);
        setLengte(lengte);
        setSnelheid(snelheid);
    }
    public Gondelbaan(String naam, String land){
        this(naam, land, 2, 6);
    }

    public String getNaam() {
        return this.naam;
    }
    public void setNaam(String naam) {
        String[] tekst = naam.split(" ");
        StringBuilder hulp = new StringBuilder();
        for (int i = 0; i < tekst.length; i++){
            hulp.append(Character.toUpperCase(tekst[i].charAt(0)) + tekst[i].substring(1).toLowerCase() + " ");

        }
        this.naam = hulp.toString().trim();
    }

    public String getLand() {
        return this.land;
    }
    public void setLand(String land) {
        this.land = controle(land);
    }

    public int getHoogteDalstation() {
        return this.hoogteDalstation;
    }

    public int getHoogteBergstation(){
        return hoogteBergstation;
    }
    public void setHoogte(int hoogte1, int hoogte2){
        if (hoogte1 > hoogte2){
            this.hoogteBergstation = hoogte1;
            this.hoogteDalstation = hoogte2;
        }else {
            this.hoogteBergstation = hoogte2;
            this.hoogteDalstation = hoogte1;
        }
    }

    public int getHoogteVershcil(){
        return this.hoogteBergstation - this.hoogteDalstation;
    }

    public double getLengte() {
        return this.lengte;
    }

    public void setLengte(double lengte) {
        this.lengte = lengte;
    }

    public double getSnelheid() {
        return this.snelheid;
    }

    public void setSnelheid(double snelheid) {
        if (snelheid < 3){
            snelheid = 3;
        } else if (snelheid > 8){
            snelheid = 8;
        }
        this.snelheid = snelheid;
    }

    public int getPassagiersPerGondel() {
        return this.passagiersPerGondel;
    }

    public void setPassagiersPerGondel(int passagiersPerGondel) {
        this.passagiersPerGondel = passagiersPerGondel;
    }

    public int getAantalGondels() {
        return this.aantalGondels;
    }
    public void setAantalGondels(int aantalGondels) {
        this.aantalGondels = aantalGondels;
    }
    public double getDuur(){
        double tijd = this.lengte * 1000 / this.snelheid;
        return tijd / 60;
    }

    public int getVervoerscapaciteit(){
        return (int) (60 * this.aantalGondels * this.passagiersPerGondel / getDuur());
    }
    private String controle(String land){
        for (String landOk : landen){
            if (land.equals(landOk)){
                return landOk;
            }
        }
        return "Onbekend";
    }

    public String toString(){
        return String.format("%s[%dm]", this.naam, getHoogteVershcil());
    }
}
