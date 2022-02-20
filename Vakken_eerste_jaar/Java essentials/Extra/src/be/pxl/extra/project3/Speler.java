package be.pxl.extra.project3;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class Speler {
    private String naam;
    private LocalDate geboortedatum;

    public Speler(String naam, LocalDate geboortedatum) {
        this.naam = naam;
        setGeboortedatum(geboortedatum);
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public LocalDate getGeboortedatum() {
        return geboortedatum;
    }

    public void setGeboortedatum(LocalDate geboortedatum) {
        if (geboortedatum.isBefore(LocalDate.now())){
            this.geboortedatum = geboortedatum;
        }else{
            System.out.println("De geboortedatum mag niet in de toekomst liggen!!");;
        }
    }
    public int getLeeftijd(){
        int leeftijd;
        if (geboortedatum == null){
            leeftijd = -1;
        }else{
            leeftijd = (int) ChronoUnit.YEARS.between(LocalDate.now(),geboortedatum);
        }
        return leeftijd;
    }
}
