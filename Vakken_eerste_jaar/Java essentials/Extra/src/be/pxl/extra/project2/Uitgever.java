package be.pxl.extra.project2;

import java.time.LocalDate;

public class Uitgever {
    private String naam;
    private int jaarOprichting;
    private String hoofdKantoor;
    private String website;

    public Uitgever(String naam,String hoofdKantoor, int jaarOprichting){
        this.naam = naam;
        this.hoofdKantoor = hoofdKantoor;
        if (jaarOprichting <= LocalDate.now().getYear()){
            setJaarOprichting(jaarOprichting);
        }else {
            setJaarOprichting(0);
        }
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getJaarOprichting() {
        return jaarOprichting;
    }

    public void setJaarOprichting(int jaarOprichting) {
        this.jaarOprichting = jaarOprichting;
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
        return String.format("Uitgever{naam='%s',jaarOprichting=%d, hoofdkantoor='%s\nwebsite='%s'}",naam,jaarOprichting,hoofdKantoor,website);
    }
}
