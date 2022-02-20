package be.pxl.h3.opdracht2;

import java.util.Scanner;

public class opdracht2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int a = 1; //dikte
        
        System.out.print("Geef het straal in: ");
        double z = scanner.nextDouble();
        scanner.nextLine();
        
        double volume = Math.PI * z * z * a;
        // double volume = Math.PI + Math.pow(z, 2) * a;
        System.out.printf("De oppervlakte van de pizza is %.2f", volume);
        volume = Math.round(volume * 100) / 100.0;
        System.out.println(volume);
    }
}
