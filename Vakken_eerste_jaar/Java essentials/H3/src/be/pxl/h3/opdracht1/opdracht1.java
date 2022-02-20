package be.pxl.h3.opdracht1;

import java.util.Scanner;

public class opdracht1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("geef waarde voor getal x in: ");
        int x = scanner.nextInt();
        int resultaat = (int) Math.pow(x, 3);
        System.out.print("Het derde macht van die getal is: " + resultaat);
    }
}
