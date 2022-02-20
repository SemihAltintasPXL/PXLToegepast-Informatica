package be.pxl.h1.opdrachten;

public class StripboekApp {
    public static void main(String[] args) {
        Stripboek stripboek = new Stripboek();

        stripboek.setReeks("One peak");
        stripboek.setTitel("One peak Chapter 1028");
        stripboek.setAlbumNummer(1028);
        stripboek.setAuteur("Oda");

        System.out.println("Titel: " + stripboek.getTitel());
        System.out.println("reeks: " + stripboek.getReeks());
        System.out.println("Albumnummer: " + stripboek.getAlbumNummer());
        System.out.println("Auteur: " + stripboek.getAuteur());

    }
}
