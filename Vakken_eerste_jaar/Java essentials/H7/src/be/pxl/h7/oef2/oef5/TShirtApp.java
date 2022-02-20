package be.pxl.h7.oef2.oef5;

import java.util.Scanner;

public class TShirtApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Tshirt[] tshirts = new Tshirt[TShirtSize.values().length * Kleur.values().length];
        int teller = 0;
        for (TShirtSize size: TShirtSize.values()){
            for (Kleur kleur: Kleur.values()){
                tshirts[teller] = new Tshirt(size, kleur);
                teller++;
            }
        }
        System.out.print("Geef uw naam in: ");
        String naam = scanner.nextLine();
        while (!(naam.equals("stop") || naam.equals("Stop"))){
            System.out.print("Geef uw Borstomtrek in: ");
            int borstomtrek = scanner.nextInt();
            scanner.nextLine();
            System.out.println();

            teller = 0;
            for (TShirtSize size: TShirtSize.values()){
                if (teller == 0 && borstomtrek <= size.getBorstomtrek()){
                    System.out.println("Dit is jouw maat " + size.getVerkorteNotatie());
                    teller++;
                }
            }
            System.out.print("geef uw gewenste kleur: ");
            int kleur = scanner.nextInt();
            for (Kleur k: Kleur.values()){
                if (kleur == k.ordinal()){
                    System.out.println(k);
                }
            }

            System.out.println("Aantal bijbesteld: ");
            int aantalBijbesteld = scanner.nextInt();
            scanner.nextLine();

            Tshirt hulp = new Tshirt(TShirtSize.EXTRA_EXTRA_EXTRA_LARGE, Kleur.WIT);
            for (int i = 0; i < tshirts.length; i++) {
                if (tshirts[i].equals(hulp)) {
                    tshirts[i].setAantalBesteld(tshirts[i].getAantalBesteld() + aantalBijbesteld);
                }
            }
            System.out.print("Geef uw naam in: ");
            naam = scanner.nextLine();
        }
        teller = 0;
        for (Kleur k: Kleur.values()){
            System.out.println(k);
            for (TShirtSize size: TShirtSize.values()){
                System.out.print(size.getVerkorteNotatie() + " ");
                teller++;
            }
            System.out.println();
        }
    }
}
