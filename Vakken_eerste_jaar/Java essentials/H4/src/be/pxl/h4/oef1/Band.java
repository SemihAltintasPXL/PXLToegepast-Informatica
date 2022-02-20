package be.pxl.h4.oef1;

import java.util.ArrayList;
import java.util.Random;

public class Band {
    private String naam;
    //private ArrayList<Muzikant> lijstMuzikanten;
    private Muzikant[] leden;

    public Band(String naam, Muzikant[] leden){
        this.naam = naam;
        this.leden = leden;
    }
    public void speel(int lengte){
        Random random = new Random();
        for (int i = 0; i < lengte; i++){
            int randomIndex = random.nextInt(leden.length);
            leden[randomIndex].speel();
        }
    }
    public String toString(){
        StringBuilder builder = new StringBuilder();
        builder.append(naam);
        builder.append("\n");

        for (Muzikant m: leden){
            builder.append(m.toString());
            builder.append("\n");
        }

        return builder.toString();
    }
}
