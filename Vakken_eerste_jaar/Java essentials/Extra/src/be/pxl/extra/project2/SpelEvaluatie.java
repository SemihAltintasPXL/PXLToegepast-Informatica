package be.pxl.extra.project2;

public class SpelEvaluatie {
    private Spel spel;
    private Speler speler;
    private Score score;
    private String motivatie;

    public SpelEvaluatie(Spel spel, Speler speler) {
        this.spel = spel;
        this.speler = speler;
    }

    public Spel getSpel() {
        return spel;
    }

    public Speler getSpeler() {
        return speler;
    }

    public Score getScore() {
        return score;
    }

    public String getMotivatie() {
        return motivatie;
    }

    public boolean maakBeoordeling(int score, String motivatie) {
        if (this.motivatie == null) {                // zo kan wordt er de tweede keer wanneer de methode opgeroepen wordt niks gebeurt
            this.motivatie = motivatie;
        }
        if (this.score == null){
            this.score = new Score(score);
        }
        return true;
    }

    public boolean isGeldig() {
        if ((spel != null && speler != null && score != null) && speler.getLeeftijd() >= spel.getMinimumLeeftijd()) {
            return true;
        }
        return false;
    }

    public String getGeldigTeken() {
        if (isGeldig()) {
            return "+";
        } else {
            return "-";
        }
    }
}
