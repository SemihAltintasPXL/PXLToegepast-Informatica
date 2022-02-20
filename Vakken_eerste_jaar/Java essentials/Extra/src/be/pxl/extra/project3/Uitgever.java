package be.pxl.extra.project3;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class Uitgever {
    private String naam;
    private LocalDate datumOprichting;
    private String hoofdKantoor;
    private String website;

    public Uitgever(String naam,String hoofdKantoor, LocalDate datumOprichting){
        this.naam = naam;
        this.hoofdKantoor = hoofdKantoor;
        if (datumOprichting.isBefore(LocalDate.now())){
            setDatumOprichting(datumOprichting);
        }else {
            setDatumOprichting(LocalDate.now().withDayOfMonth(1));
        }
    }

    public long getMaandenSindsOprichting(){
        return ChronoUnit.MONTHS.between(LocalDate.now(),datumOprichting);
    }
    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public LocalDate getDatumOprichting() {
        return datumOprichting;
    }

    public void setDatumOprichting(LocalDate datumOprichting) {
        this.datumOprichting = datumOprichting;
    }

    public String getHoofdKantoor() {
        return hoofdKantoor;
    }

    public void setHoofdKantoor(String hoofdKantoor) {
        this.hoofdKantoor = hoofdKantoor;
    }

    public String getWebsite() {
        return website;
    }

    public void setWebsite(String website) {
        this.website = website;
    }
    public String toString(){
        return String.format("Uitgever{naam='%s',jaarOprichting=%d, hoofdkantoor='%s\nwebsite='%s'}",naam, datumOprichting.getYear(),hoofdKantoor,website);
    }
}
