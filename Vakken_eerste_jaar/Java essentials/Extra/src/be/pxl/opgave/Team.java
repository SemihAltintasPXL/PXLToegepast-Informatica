package be.pxl.opgave;
/* naam: */

public class Team {
    private Sport sport;
    private Speler[] spelers;
    public final int MAX = 10;

    public Team(Sport sport) {
        this.sport = sport;
        spelers = new Speler[this.sport.getAantalSpelers()];
    }
    public boolean spelerKomtVoor(Speler speler) {
        for(Speler speler1 : spelers) {
            if (speler.equals(speler1)) {
                return true;
            }
        }
        return false;
    }
    public int vindVrijePositie() {
        for(int i = 0; i < spelers.length; i++) {
            if (spelers[i] == null) {
                return i;
            }
        }
        return -1;
    }

    public void voegSpelerToe(Speler speler) {
        if (spelerKomtVoor(speler)){
            System.out.println("FOUTIEVE INGAVE");
            return;
        }
        if (speler.getSport() != sport){
            System.out.println("FOUTIEVE INGAVE");
            return;

        }
        int index = vindVrijePositie();
        if (index == -1){
            System.out.println("FOUTIEVE INGAVE");
            return;
        }
        spelers[index] = speler;
    }





    public boolean spelerIdKomtVoor(String id) {
        return spelerKomtVoor(new Speler(id));
    }
    public String toString(){
        if (vindVrijePositie() == -1){
            StringBuilder stringBuilder = new StringBuilder();
            for (Speler speler: spelers){
                stringBuilder.append(speler.toString() + "\n");
            }
            return stringBuilder.toString();
        }
        return "ONVELLEDIG TEAM";
    }




























}
