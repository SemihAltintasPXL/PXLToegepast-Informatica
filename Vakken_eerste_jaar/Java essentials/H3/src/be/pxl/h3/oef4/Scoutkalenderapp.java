package be.pxl.h3.oef4;

import java.util.Scanner;

public class Scoutkalenderapp {
    public static void main(String[] args) {
        Scanner invoer = new Scanner(System.in);
        System.out.println("Geef een maandnr in: ");
        int maand = invoer.nextInt();
        System.out.println("Geef een jaar in: ");
        int jaar = invoer.nextInt();

        Datum datumArray[] = new Datum[10];
        String activiteitArray[] = new String[10];
        String activiteit;
        int tel = 0;

        System.out.println("Geef een dag in: ");
        int dag = invoer.nextInt();
        while (dag != 0) {
            invoer.nextLine(); //rariteit
            System.out.println("Geef de activiteit in: ");
            activiteit = invoer.nextLine();
            datumArray[tel] = new Datum(dag, maand, jaar);
            activiteitArray[tel] = activiteit;
            tel++;
            System.out.println("Geef een dag in:");
            dag = invoer.nextInt();
        }


        System.out.println("**** Kalender voor " + datumArray[0].getMaandNaam() + " " + datumArray[0].getJaar() + " ****");
        for (int i = 0; i < tel; i++) { //activiteintArray.length ook oke? nee test maar dat is een NullPointerException
            System.out.printf("%-20s", datumArray[i].toString());
            System.out.printf("%-20s %n", activiteitArray[i]);
        }
        invoer.close();
    }
}
