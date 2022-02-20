package be.pxl.extra.project2;

import java.util.Scanner;

public class SpelApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder stringBuilder = new StringBuilder();

        Uitgever riot = new Uitgever("Riot","L.A",2005);
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

            System.out.println("Geef geboortejaar:");
            int geboortejaar = scanner.nextInt();
            spelers[i] = new Speler(naam,geboortejaar);

            System.out.println("Geef uw score (0-5)");
            int score = scanner.nextInt();

            scoreLijst[i] = new Score(score);

            System.out.println("Geef uw motivatie:");
            String motivatie = scanner.next();
            scanner.nextLine();

            SpelEvaluatie spelEvaluatie = new SpelEvaluatie(league,spelers[i]);
            spelEvaluatie.maakBeoordeling(score,motivatie);

            stringBuilder.append(String.format("%-8s %5s %s %s\n",spelers[i].getNaam(),spelEvaluatie.getScore().getStars(),spelEvaluatie.getMotivatie(),spelEvaluatie.getGeldigTeken()));
        }
        System.out.println("Evaluatie "+league.getNaam()+" "+riot.getNaam() +"\n");
        System.out.println(stringBuilder.toString());
        Score totaalScore = new Score(scoreLijst);
        System.out.println("Totaalscore: " +totaalScore.getStars());

    }

}
