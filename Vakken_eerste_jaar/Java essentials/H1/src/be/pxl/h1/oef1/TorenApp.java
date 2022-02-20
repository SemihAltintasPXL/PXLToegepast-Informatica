package be.pxl.h1.oef1;

public class TorenApp {
    public static void main(String[] args) {
        Toren toren = new Toren();
        toren.setNaam("Zuidertoren");
        toren.setLocatie(("Sint-Gillis,Brussel"));
        toren.setJaarVoltooid(1967);
        toren.setHoogte(150);
        toren.setAantalVerdiepingen(37);

        System.out.println(toren.getNaam());
        System.out.println(toren.getLocatie());
        System.out.println(toren.getHoogte());
        System.out.println(toren.getAantalVerdiepingen());


    }
}
