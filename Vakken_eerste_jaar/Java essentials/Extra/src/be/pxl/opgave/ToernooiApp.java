package be.pxl.opgave;

public class ToernooiApp {
    public static void main(String[] args) {

        Speler speler1 = new Speler("A12AA", "Tim Schuermans", Sport.TENNIS);
        Speler speler2 = new Speler("B234", "Mieke Verlaek", Sport.TENNIS);
        Team team1 = new Team(Sport.TENNIS);
        team1.voegSpelerToe(speler1);
        team1.voegSpelerToe(speler2);

        Speler speler3 = new Speler("FDSS", "Hilde Voorts", Sport.TENNIS);
        Speler speler4 = new Speler("QEEDD", "Marleen Elders", Sport.TENNIS);
        Team team2 = new Team(Sport.TENNIS);
        team2.voegSpelerToe(speler3);
        team2.voegSpelerToe(speler4);

        Scheidsrechter scheidsrechter = new Scheidsrechter("aqd", "Jef Schepis");

        Wedstrijd wedstrijd = new Wedstrijd(team1, team2, scheidsrechter, 12, 5, 2019, 9, 5);
        wedstrijd.setScore(4, 3);

        Wedstrijd wedstrijd2 = new Wedstrijd(team2, team1, scheidsrechter, 12, 9, 2019, 14, 0);
        Wedstrijd wedstrijd3 = new Wedstrijd(team1, null, scheidsrechter, 1, 9, 2019, 9, 5);

        Toernooi toernooi = new Toernooi();

        toernooi.voegWedstrijdToe(wedstrijd);
        toernooi.voegWedstrijdToe(wedstrijd2);
        toernooi.voegWedstrijdToe(wedstrijd3);
        System.out.println(toernooi.zoekDatumVolgendeWedstrijdVan("A12"));
        System.out.println(toernooi.zoekDatumVolgendeWedstrijdVan("NNN"));
        /* output:
        2019-09-01T09:05
        null
         */
    }
}
