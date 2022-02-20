package be.pxl.h6.oef2;

import java.lang.reflect.Array;
import java.util.*;

public class KaartApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Kaart[] kaart = new Kaart[52];
        int tel = 0;
        for (Ranking r : Ranking.values()) { //r = TWEE ==> new Kaart(r, s)
            for (Soort s : Soort.values()) { //s = HARTEN
                kaart[tel] = new Kaart(r, s);
                tel++;
            }
        }

        // kaarten door elkaar schudden
        Collections.shuffle(Arrays.asList(kaart)); // ArrayList


        Random rand = new Random();
        int computer = rand.nextInt(tel);
        System.out.println("Het getal van de computer is " + computer); //kaart(computer)


        int speler;
        System.out.println("Trek een willekeurig getal >= en <= 51");
        speler = scanner.nextInt();
        while (!(speler >= 0 && speler < tel)){
            System.out.println("Je moet een getal  >= 0 en <= 51 ingeven");
            speler = scanner.nextInt();
        }
        System.out.println("Het getal van de speler is " + speler); //kaart[speler]

        if (kaart[computer].getWaarde().ordinal() > kaart[speler].getWaarde().ordinal()){
            System.out.printf("Winnaar computer %s \nVerliezer speler %s%n", kaart[computer], kaart[speler]);
        }else if (kaart[computer].getWaarde().ordinal() < kaart[speler].getWaarde().ordinal()){
            System.out.printf("Winnaar speler %s \nVerliezer computer %s%n", kaart[computer], kaart[speler]);
        }else{
            System.out.println("geen winnaar !!");
        }
    }
}
