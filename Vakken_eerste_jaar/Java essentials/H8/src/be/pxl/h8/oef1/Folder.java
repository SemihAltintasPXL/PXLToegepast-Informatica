package be.pxl.h7.oef1;

import java.util.ArrayList;
import java.util.Arrays;

public class Folder implements Uitvoerbaar{
    private String naam;
    private ArrayList<Bestand> bestanden;

    public Folder(String naam) {
        this.naam = naam;
        bestanden = new ArrayList<>();
    }

    public void voegBestandenToe(Bestand[] bestand){
        for (Bestand b: bestand){
            bestanden.add(b);
        }
        //bestanden.addAll(Arrays.asList(bestand));
    }

    @Override
    public void voeruit() {
        System.out.println(naam + "\n");
        for (Bestand b: bestanden){
            System.out.println(b.toString());
        }
    }
}
