package be.pxl.h7.oef3;

import java.time.Instant;
import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class TypingGame {

    public static final int AANTAL_LETTERS = 5;

    public static void main(String[] args) {
        Result highscore = FileHandler.readHighscore();

        System.out.println("Geef je naam in:");
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        System.out.printf("Welkom, %s!%n", name);
        System.out.printf("Er worden zo dadelijk %d letters getoond die je zo snel mogelijk moet ingeven.%nSucces!!%n", AANTAL_LETTERS);

        if(highscore == null) {
            System.out.println("Er is nog geen highscore!");
        } else {
            System.out.println("De huidige highscore:");
            System.out.println(highscore);
        }
        System.out.println("Geef 's' in om te starten");
        while(!scanner.nextLine().equalsIgnoreCase("s")) {
            System.out.println("Geef 's' in om te starten");
        }

        Instant start = Instant.now();
        for(int i=0;i<AANTAL_LETTERS;i++) {
            char opdracht = 'a';
            opdracht += (int) (Math.random()*26);
            System.out.printf("Typ '%c'%n", opdracht);
            while(scanner.nextLine().charAt(0) != opdracht) {
                System.out.println("Fout..");
            }
        }
        Instant end = Instant.now();

        Result result = new Result(name, LocalDateTime.now(), ChronoUnit.MILLIS.between(start, end)/1000.0);

        if(highscore == null || highscore.getResult() > result.getResult()) {
            System.out.println("### NIEUWE HIGHSCORE ###");
            System.out.println(result);
            FileHandler.writeHighscore(result);

            System.out.println("\nVorige highscore was:");
            System.out.println(highscore);
        } else {
            System.out.println("Resultaat:");
            System.out.println(result);
            System.out.println("Geen nieuwe highscore, volgende keer beter...");
            System.out.println("\nHuidige highscore:");
            System.out.println(highscore);
        }
    }
}
