package be.pxl.h6.oef1;

import java.util.Scanner;

public class MuntApp {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Geef een bedrag in (euro): ");
        double bedrag = input.nextDouble();
        while (!(bedrag > 0 && bedrag < 10)) {
            System.out.println("Foute invoer, het bedrag moet >0 en <10 zijn");
            bedrag = input.nextDouble();        // voor kommagetal ',' gebruiken en geen '.'
        }
        int cent = (int)Math.round(bedrag * 100);
        for (Munt munt : Munt.values()) {
            int aantalMunten =  cent / munt.getWaarde();
            cent %= munt.getWaarde();
            System.out.println(aantalMunten + " munt(en) van " + munt.name());
        }
    }
}