package be.pxl.opgave;
/* naam: */

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;

public class Wedstrijd implements DatumVergelijkbaar{
    private final static DateTimeFormatter FORMAT =  DateTimeFormatter.ofPattern("dd/MM/yy hh:mm");
    private LocalDateTime wedstrijdDatum;
    private Team team1;
    private Team team2;
    private Scheidsrechter scheidsrechter;
    private int scoreTeam1;
    private int scoreTeam2;

    public Wedstrijd(Team team1, Team team2, Scheidsrechter scheidsrechter, int dag, int maand, int jaar , int uur, int minuut){
        this.team1 = team1;
        this.team2 = team2;
        this.scheidsrechter = scheidsrechter;
        this.wedstrijdDatum = LocalDateTime.of(jaar, maand, dag, uur, minuut);

    }
    public boolean spelerIdKomtVoor(String id){
        if (team1 != null && team2 != null){
            if (team1.spelerIdKomtVoor(id) || team2.spelerIdKomtVoor(id)){
                return true;
            }
        }
        return false;
    }

    @Override
    public long berekenAantalMinutenNa(LocalDateTime dateTime) {
        return ChronoUnit.MINUTES.between(wedstrijdDatum, dateTime);
    }

    public LocalDateTime getWedstrijdDatum() {
        return wedstrijdDatum;
    }
    public void setScore(int scoreTeam1, int scoreTeam2){
        this.scoreTeam1 = scoreTeam1;
        this.scoreTeam2 = scoreTeam2;
    }
    public String toString(){
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("TEAM1 \n");
        stringBuilder.append(team1);
        stringBuilder.append("TEAM2 \n");
        stringBuilder.append(team2);
        stringBuilder.append(wedstrijdDatum.format(FORMAT) + "\n");
        stringBuilder.append("SCHEIDSRECHTER" + scheidsrechter + "\n");
        if (berekenAantalMinutenNa(LocalDateTime.now()) >= 0){
            stringBuilder.append("SCORE " + scoreTeam1 +" " + scoreTeam2);
        }
        return stringBuilder.toString();
    }
}
