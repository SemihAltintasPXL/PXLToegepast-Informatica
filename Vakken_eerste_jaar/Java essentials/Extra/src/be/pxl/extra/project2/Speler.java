package be.pxl.extra.project2;

import java.time.LocalDate;

public class Speler {
    private String naam;
    private int geboortejaar;

    public Speler(String naam, int geboortejaar) {
        this.naam = naam;
        setGeboortejaar(geboortejaar);
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getGeboortejaar() {
        return geboortejaar;
    }

    public void setGeboortejaar(int geboortejaar) {
        if (geboortejaar < 1900 || geboortejaar > LocalDate.now().getYear()){
            this.geboortejaar = 0;
        }else{
            this.geboortejaar = geboortejaar;
        }
    }
    public int getLeeftijd(){
        int leeftijd;
        if (geboortejaar == 0){
            leeftijd = -1;
        }else{
            leeftijd =LocalDate.now().getYear() - geboortejaar;
        }
        return leeftijd;
    }
}
