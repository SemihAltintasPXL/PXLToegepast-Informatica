package be.pxl.h1.oef3;

import java.util.Scanner;

public class VoetballerApp {
    public static void main(String[] args) {
        Voetballer voetballer = new Voetballer();
        Scanner input = new Scanner(System.in);
        System.out.print("Naam: ");
        voetballer.setNaam(input.nextLine());
        while (!voetballer.getNaam().equals("stop")){
            System.out.print("Leeftijd: ");
            voetballer.setLeeftijd(input.nextInt());
            input.nextLine();
            System.out.print("Positie: ");
            voetballer.setType(input.nextLine());
            System.out.print("Beoordeling: ");
            voetballer.setBeoordeling(input.nextInt());
            System.out.print("Doelpunten: ");
            voetballer.setAantal_doelpunten(input.nextInt());
            input.nextLine();
            System.out.printf("Prijs: €%.2f%n",voetballer.berekenPrijs());

            System.out.print("Geef de naam van de speler: ");
            voetballer.setNaam(input.nextLine());

        }






    }
}
