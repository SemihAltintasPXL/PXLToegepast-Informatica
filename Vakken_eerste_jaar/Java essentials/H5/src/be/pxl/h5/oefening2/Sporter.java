package be.pxl.h5.oefening2;

import be.pxl.h5.oefening1.Persoon;

public class Sporter extends Persoon {
    private String omschrijving;
    private static int aantal = 0;

    public Sporter(String naam, String voornaam){
        this(naam, voornaam, "onbepaald");
    }
    public Sporter(String naam, String voornaam, String omschrijving){
        super(naam, voornaam);
        setOmschrijving(omschrijving);
        aantal++;
    }

    public String getOmschrijving() {
        return omschrijving;
    }

    public void setOmschrijving(String omschrijving) {
        this.omschrijving = omschrijving;
    }

    public static int getAantal() {
        return aantal;
    }
    public void print(){
        super.print();
        System.out.println(omschrijving);
    }
}
