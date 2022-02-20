package be.pxl.h8.oef2;

import java.util.Random;

public class Battleship {
    public static void main(String[] args) {
        Spel battleship = new Spel();

        Schip schip1 = new Schip(1,1, Alliantie.NOORD, 100, 10);
        Schip schip2 = new Schip(2,2, Alliantie.NOORD, 150, 8);
        Schip schip3 = new Schip(7,7,Alliantie.ZUID, 150, 8);
        Schip schip4 = new Schip(8,8,Alliantie.ZUID, 200, 6);

        GewapendeBoei boei1 = new GewapendeBoei(0,0,Alliantie.NOORD,70,3,80);
        GewapendeBoei boei2 = new GewapendeBoei(9,9,Alliantie.ZUID,70,3,80);
        GewapendeBoei boei3 = new GewapendeBoei(4,4,Alliantie.NOORD, 200,7,20);
        GewapendeBoei boei4 = new GewapendeBoei(5,5,Alliantie.ZUID, 200,7,20);

        battleship.voegZeeObjectToe(schip1);
        battleship.voegZeeObjectToe(schip2);
        battleship.voegZeeObjectToe(schip3);
        battleship.voegZeeObjectToe(schip4);
        battleship.voegZeeObjectToe(boei1);
        battleship.voegZeeObjectToe(boei2);
        battleship.voegZeeObjectToe(boei3);
        battleship.voegZeeObjectToe(boei4);

        Random random = new Random();
        for(int i=1;i<=10;i++) {
            System.out.println("Round " + i);

            // Beweeg 5 willekeurig geselecteerde zeeobjecten
            for(int j=0;j<5;j++) {
                int randomIndex = random.nextInt(battleship.getAantalZeeObjecten());
                Punt randomPunt = new Punt(random.nextInt(Punt.MAXIMUMGROOTTE), random.nextInt(Punt.MAXIMUMGROOTTE));
                battleship.beweegZeeObject(randomIndex, randomPunt);
            }

            battleship.vuur();
            battleship.printStatus();
        }

    }
}
