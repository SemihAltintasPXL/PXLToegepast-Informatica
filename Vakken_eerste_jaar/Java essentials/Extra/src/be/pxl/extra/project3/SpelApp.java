package be.pxl.extra.project3;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Date;
import java.util.Scanner;

public class SpelApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder stringBuilder = new StringBuilder();

        Uitgever riot = new Uitgever("Riot","L.A",LocalDate.of(1999,6,20));
        riot.setWebsite("www.riotgames.com");
        OnlineSpel league = new OnlineSpel("League of Legends",riot);
        league.setGenre("MOBA");
        league.setUrl("prod.eu.lol.riotgames.com");
        System.out.println(league.toString());
        System.out.println();
        System.out.println("Hoeveel spelers evalueren het spel?");
        int aantalSpelers = scanner.nextInt();

        Speler[] spelers = new Speler[aantalSpelers];
        Score[] scoreLijst = new Score[aantalSpelers];

        for (int i = 0; i < aantalSpelers;i++){
            System.out.println("Geef speler naam: ");
            String naam = scanner.next();
            scanner.nextLine();

            System.out.println("Geef geboortedatum (formaat dd-MM-yyyy):");
            String geboortejaarString = scanner.next();
            DateTimeFormatter parser = DateTimeFormatter.ofPattern("dd-MM-yyyy");
            LocalDate geboortejaar = LocalDate.parse(geboortejaarString,parser);
            spelers[i] = new Speler(naam,geboortejaar);

            System.out.println("Geef uw score (0-5)");
            int score = scanner.nextInt();

            scoreLijst[i] = new Score(score);

            System.out.println("Geef uw motivatie:");
            String motivatie = scanner.next();
            scanner.nextLine();



            SpelEvaluatie spelEvaluatie = new SpelEvaluatie(league,spelers[i]);
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm");
            String tijdstip = formatter.format(spelEvaluatie.getTijdstip());
            spelEvaluatie.maakBeoordeling(score,motivatie);

            stringBuilder.append(String.format("%6s %-8s %5s %s %s\n",tijdstip,spelers[i].getNaam(),spelEvaluatie.getScore().getStars(),spelEvaluatie.getMotivatie(),spelEvaluatie.getGeldigTeken()));
        }
        System.out.println("Evaluatie "+league.getNaam()+" "+riot.getNaam() +"\n");
        System.out.println(stringBuilder.toString());
        Score totaalScore = new Score(scoreLijst);
        System.out.println("Totaalscore: " +totaalScore.getStars());


    }

}
