package be.pxl.h3.opdracht11;

import java.time.LocalDate;

public class Opdracht11 {
    public static void main(String[] args) {

        LocalDate datum = LocalDate.now();
        System.out.println(datum);

        LocalDate geboorte = LocalDate.of(1987, 4, 3);
        System.out.println(geboorte);

        System.out.println("Dag van het jaar: " + geboorte.getDayOfYear());
        System.out.println("Welke dag? "+ geboorte.getDayOfWeek());
        System.out.println("Schrikkel? " + geboorte.isLeapYear());
    }
}
