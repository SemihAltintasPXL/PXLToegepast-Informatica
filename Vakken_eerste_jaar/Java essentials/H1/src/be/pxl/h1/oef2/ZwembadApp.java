package be.pxl.h1.oef2;

import java.util.Scanner;

public class ZwembadApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Zwembad zwembad = new Zwembad();

        System.out.print("Geef uw breedte in: ");
        double breedte = scanner.nextDouble();
        zwembad.setBreedte(breedte);
        System.out.print("Geef uw lengte in: ");
        double lengte = scanner.nextDouble();
        zwembad.setLengte(lengte);
        System.out.print("Geef uw diepte in: ");
        double diepte = scanner.nextDouble();
        zwembad.setDiepte(diepte);
        System.out.printf("Liter water: %.2f%n",zwembad.getVolumeWater());
        System.out.printf("Liter ontsmettingsmiddel: %.2f",zwembad.getVolumeOntsmettingsmiddel());


    }
}
