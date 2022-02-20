package be.pxl.opgave;
/* naam: */

import java.time.LocalDateTime;

public class Toernooi {
    private Wedstrijd[] wedstrijden;
    private static final int MAX_AANTAL_WEDSTRIJDEN = 10;

    public Toernooi(){
        wedstrijden = new Wedstrijd[MAX_AANTAL_WEDSTRIJDEN];
    }
    public void voegWedstrijdToe(Wedstrijd wedstrijd){
        int index = vindVrijePositie();
        if (index == -1 ){
            System.out.println("geen ruimte meer voor wedstrijden");
        }
        wedstrijden[index] = wedstrijd;
    }
    public int vindVrijePositie() {
        for(int i = 0; i < wedstrijden.length; i++) {
            if (wedstrijden[i] == null) {
                return i;
            }

        }
        return -1;
    }
    public LocalDateTime zoekDatumVolgendeWedstrijdVan(String spelerid){
        for (Wedstrijd w : wedstrijden){
            if (w.spelerIdKomtVoor(spelerid)){
                return w.getWedstrijdDatum();
            }
            else {
                return null;
            }
        }
        return null;
    }
}

