package be.pxl.h7.opdracht3;

import java.time.Instant;
import java.util.Scanner;

public class Opdracht3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Instant before = Instant.now();
        String s  = scanner.nextLine();
        Instant after = Instant.now();

        long diff = after.toEpochMilli() - before.toEpochMilli();
        double seconds = diff / 1000.0;
        System.out.println(seconds + " s");
    }
}
