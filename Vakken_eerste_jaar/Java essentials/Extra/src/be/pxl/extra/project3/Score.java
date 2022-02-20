package be.pxl.extra.project3;

public class Score {
    public static final int MAX_SCORE = 5;
    private int waarde;

    public Score(int waarde) {
        setWaarde(waarde);
    }
    public Score(Score[] scoreLijst){
        double totaal = 0;
        for (Score s:scoreLijst){
            totaal += s.waarde;
        }
        setWaarde((int) Math.floor(totaal / scoreLijst.length));    // math.floor -> naar beneden afronden
    }

    public void setWaarde(int waarde) {
        if (waarde < 0) {
            this.waarde = 0;
        } else if (waarde > MAX_SCORE) {
            this.waarde = MAX_SCORE;
        } else {
            this.waarde = waarde;
        }
    }

    public String getStars(){
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < waarde;i++){
            stringBuilder.append("*");
        }
        return stringBuilder.toString();
    }
    public boolean equals(Score score){
        return waarde == score.waarde;      // als de waarde van de score-objecten gelijk zijn --> true
    }
}
