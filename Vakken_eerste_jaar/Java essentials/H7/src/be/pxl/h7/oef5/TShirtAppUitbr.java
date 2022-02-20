package be.pxl.h7.oef5;

import java.util.Scanner;

public class TShirtAppUitbr {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int telMaat = TShirtSize.values().length;
        int telKleur = Kleur.values().length;
        TShirt[][] tshirt = new TShirt[telKleur][telMaat];
        for (Kleur k : Kleur.values()) {
            for (TShirtSize s : TShirtSize.values()) {
                tshirt[k.ordinal()][s.ordinal()] = new TShirt(s, k);
            }
        }
        System.out.print("geef een naam in: ");
        String naam = input.next();
        while (!(naam.equals("stop") || naam.equals("Stop"))) {
            System.out.print("Geef borstomtrek in: ");
            int borst = input.nextInt();
            int i = 0;
            while (i < telMaat - 1 && TShirtSize.values()[i].getBorst() < borst) {
                i++;
            }

            System.out.println("de maat die nodig is " + TShirtSize.values()[i]);
            System.out.print("Welke kleur wenst u? Beschikbare kleuren");
            for (Kleur k : Kleur.values()) {
                System.out.print(k + " (ingave " + k.ordinal() + ") ");
            }
            int keuze = input.nextInt();
            System.out.print("aantal bestelde artikelen? ");
            int aantal = input.nextInt();
            tshirt[keuze][i].setAantal(aantal + tshirt[keuze][i].getAantal());
            System.out.print("geef een naam in ");
            naam = input.next();
        }
        // tabel afprinten + bepalen welke kleur het vaakst.
        int aantMaxKl = 0;
        int maxKleur = 0;
        System.out.printf("%12s", " ");
        for (TShirtSize s : TShirtSize.values()){
            System.out.printf("%10s   ", s);
        }
        System.out.println();
        for (Kleur k : Kleur.values()) {
            System.out.printf("%12s", k.name().toLowerCase());
            int somKl = 0;
            for (TShirtSize s : TShirtSize.values()) {
                somKl = somKl + tshirt[k.ordinal()][s.ordinal()].getAantal();
                System.out.printf("%10d   ", tshirt[k.ordinal()][s.ordinal()].getAantal());
            }
            System.out.println();
            if (somKl > aantMaxKl) {
                maxKleur = k.ordinal();
                aantMaxKl = somKl;
            }
        }
        System.out.println("De kleur die het vaakst besteld werd is " + Kleur.values()[maxKleur]);

        // bepalen welke maat het minst
        int somMin = aantMaxKl;
        int minMaat = 0;
        for (TShirtSize s : TShirtSize.values()) {
            int som = 0;
            for (Kleur k : Kleur.values()) {
                som = som + tshirt[k.ordinal()][s.ordinal()].getAantal();
            }
            if (som < somMin) {
                somMin = som;
                minMaat = s.ordinal();

            }
        }
        System.out.println("De maat die het minst vaak besteld besteld werd is " + TShirtSize.values()[minMaat]);
        input.close();
    }

}

