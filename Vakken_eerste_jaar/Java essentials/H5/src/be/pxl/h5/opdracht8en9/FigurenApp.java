package be.pxl.h5.opdracht8en9;

public class FigurenApp {
    public static void main(String[] args) {

        Cirkel cirkel = new Cirkel(1,1,1);

        System.out.println(cirkel);

        System.out.printf("Omtrek: %.2f, opp: %.2f%n", cirkel.getOmtrek(), cirkel.getOppervlakte());
    }
}
