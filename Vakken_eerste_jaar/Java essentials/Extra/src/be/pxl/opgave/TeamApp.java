package be.pxl.opgave;

public class TeamApp {
    public static void main(String[] args) {
        Speler speler1 = new Speler("A12AA", "Tim Schuermans", Sport.TENNIS);
        Speler speler2 = new Speler("A12AA", "Mieke Verlaek", Sport.TENNIS);
        Speler speler3 = new Speler("QQQ", "Hilde Voorts", Sport.VOETBAL);
        Speler speler4 = new Speler("QEE", "Marleen Elders", Sport.TENNIS);
        Speler speler5 = new Speler("A223", "Nele Veltegem", Sport.TENNIS);
        Team team1 = new Team(Sport.TENNIS);

        team1.voegSpelerToe(speler1);
        System.out.println(team1.toString());
        team1.voegSpelerToe(speler2);
        System.out.println(team1.toString());
        team1.voegSpelerToe(speler3);
        System.out.println(team1.toString());
        team1.voegSpelerToe(speler4);
        System.out.println(team1.toString());
        team1.voegSpelerToe(speler5);
        System.out.println(team1.toString());
        /* output
        ONVOLLEDIG TEAM
        FOUTIEVE INGAVE
        ONVOLLEDIG TEAM
        FOUTIEVE INGAVE
        ONVOLLEDIG TEAM
        [A12] Tim Schuermans (ten)
        [QEE] Marleen Elders (ten)

        FOUTIEVE INGAVE
        [A12] Tim Schuermans (ten)
        [QEE] Marleen Elders (ten)

         */
    }
}
