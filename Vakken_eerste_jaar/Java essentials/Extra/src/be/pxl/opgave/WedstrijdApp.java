package be.pxl.opgave;

import java.time.LocalDate;
import java.time.LocalDateTime;

public class WedstrijdApp {
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

        Wedstrijd wedstrijd = new Wedstrijd(team1, team2, scheidsrechter, 1, 9, 2007, 9, 5);
        wedstrijd.setScore(4, 3);
        System.out.println(wedstrijd.toString());
        /* output
        TEAM1
        [A12] Tim Schuermans (ten)
        [B23] Mieke Verlaek (ten)
        TEAM2
        [FDS] Hilde Voorts (ten)
        [QEE] Marleen Elders (ten)
        01/09/07 09:05
        SCHEIDSRECHTER [AQD] Jef Schepis <ref>
        SCORE 4 3
        */
    }
}
