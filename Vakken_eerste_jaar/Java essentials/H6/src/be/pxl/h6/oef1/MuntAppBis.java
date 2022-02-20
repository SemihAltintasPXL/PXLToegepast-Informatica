package be.pxl.h6.oef1;

import java.nio.file.LinkPermission;
import java.util.Random;

public class MuntAppBis {
    public static void main(String[] args) {
        int[] tel = new int[Munt.values().length];
        Random rand = new Random();
        int hulp = rand.nextInt(999) + 1;
        double euro = hulp / 100.0;
        System.out.printf("De computer heeft het bedrag %.2f gegenereerd\n", euro);

        for (Munt m : Munt.values()){
            tel[m.ordinal()] = hulp / m.getWaarde();
            hulp = hulp % m.getWaarde();
        }
        for (Munt m:Munt.values()){
            if (tel[m.ordinal()] != 0){
                System.out.println(tel[m.ordinal()] + " " + m.name() + "   ");
            }
        }


    }
}
