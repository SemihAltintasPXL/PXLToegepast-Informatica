package be.pxl.h7.oef2;

import java.util.ArrayList;
import java.util.Random;

public class BingoApp {
    public static void main(String[] args) {
        Random random = new Random();
        BingoCard bingoCard = new BingoCard("Tupac");
        BingoCard bingoCard1 = new BingoCard("Shakur");
        BingoCard bingoCard2 = new BingoCard("kerim");
        BingoCard bingoCard3 = new BingoCard("semih");

        BingoCard[] bcards = {bingoCard, bingoCard1, bingoCard2, bingoCard3};


        for (BingoCard j : bcards) {
            for (int i = 0; i < 6; i++) {
                int randomGetal = random.nextInt(101);
                j.addNumber(randomGetal);
            }
        }
        System.out.println(bingoCard.toString());
        System.out.println(bingoCard1.toString());
        System.out.println(bingoCard2.toString());
        System.out.println(bingoCard3.toString());

        boolean isErWinnaar = false;
        while (!(isErWinnaar)) {
            int bingoLot = random.nextInt( 101);
            System.out.printf("Nummer %d getrokken...%n", bingoLot);
            for (BingoCard b : bcards) {
                if (b.hasNumber(bingoLot)) {
                    System.out.println("BINGO!! EYYYYYYY");
                    System.out.println(b);
                    isErWinnaar = true;
                    break;
                }
            }
        }
    }
}