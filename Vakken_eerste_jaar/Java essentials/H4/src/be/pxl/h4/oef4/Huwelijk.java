package be.pxl.h4.oef4;

import java.time.LocalDate;

public class Huwelijk {
    private Persoon partner1;
    private Persoon partner2;
    private LocalDate huwelijksDatum;

    public Huwelijk(Persoon partner1, Persoon partner2, int dag, int maand, int jaar){
        huwelijksDatum = LocalDate.of(jaar, maand, dag);
        this.partner1 = partner1;
        this.partner2 = partner2;

        this.partner2.setAdres(this.partner1.getAdres());
        System.out.println(partner1.getVoornaam() + partner1.getNaam() + " "+ partner2.getVoornaam() + " " + partner1.getNaam() + "zijn gehuwd op");
        System.out.println(huwelijksDatum.toString());
    }

    public Persoon getPartner1() {
        return partner1;
    }

    public Persoon getPartner2() {
        return partner2;
    }

    public LocalDate getHuwelijksdatum() {
        return huwelijksDatum;
    }
    public void adresWijziging(String straat,String huisNummer, int postcode, String gemeentenaam){
        Adres ad = new Adres(straat, huisNummer, postcode, gemeentenaam);
        partner1.setAdres(ad);
        partner2.setAdres(ad);
    }
    public void print(){
        System.out.println(partner1.toString());
        System.out.print("Geboren op ");
        System.out.println(partner1.getGeboortedatum().toString());
        System.out.println();

        System.out.println(partner2.toString());
        System.out.print("Geboren op ");
        System.out.println(partner2.getGeboortedatum().toString());
        System.out.println();

        System.out.print("Het huwelijk vond plaats op ");
        System.out.println(huwelijksDatum.toString());


    }
}
