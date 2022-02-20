package be.pxl.h7.opdracht4;

import java.time.DayOfWeek;
import java.util.Scanner;

public class Opdracht4 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Geef eens startdag (1-7)");
        int dag = scanner.nextInt();
        scanner.nextLine();

        DayOfWeek startdag = DayOfWeek.of(dag);
        System.out.println(">>> " + startdag);

        System.out.println("Geef een aantal dagen");
        int aantal = scanner.nextInt();
        scanner.nextLine();

        DayOfWeek resultaat = startdag.plus(aantal);
        System.out.println(">>>>>>>> " + resultaat);
    }
}
