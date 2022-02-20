package be.pxl.h7.oef1;

import java.util.Random;

public class Afbeelding extends Bestand{
    private int[] dimensies;

    public Afbeelding(String inhoud, int[] dimensies) {
        super(inhoud);
        int hoogte = dimensies[0];
        int breedte = dimensies[1];
    }

    @Override
    public void voeruit() {
        System.out.println(getNaam());
        Random random = new Random();
        for (int i = 0; i < dimensies[0]; i++){
            for (int j = 0; j < dimensies[1]; j++){
                System.out.print(getInhoud().charAt(random.nextInt(getInhoud().length())));
            }
            System.out.println();
        }
    }
}
