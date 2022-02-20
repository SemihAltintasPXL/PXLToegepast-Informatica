package be.pxl.h3.opdracht3;

import java.util.Random;

public class Opdracht3 {
    public static void main(String[] args) {
        Random random = new Random();

        System.out.println(random.nextInt());

        for(int i=0;i<20;i++) {
            System.out.println(random.nextInt(11));
        }

        for(int i=0;i<10;i++) {
            System.out.println(random.nextInt(20,31));
        }

        char a = 'a'; // 97
        int r = random.nextInt(26);
        a = (char) (a+r);
        System.out.println(a);
    }
}
