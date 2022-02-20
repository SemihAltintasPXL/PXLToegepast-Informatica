package be.pxl.h3.oef2;

public class MuntApp {
    public static void main(String[] args) {

        Munt amDollar = new Munt("Amerikaanse dollar", 1.1260);
        Munt brPond = new Munt("Britse Pond", 0.8757);
        Munt euro = new Munt();
        Munt rusRoebel = new Munt("Russische roebel", 76.1420);
        Munt testMunt = new Munt("testmunt", 0.5);
        Munt testMunt2 = new Munt("testmunt2", 2);

        Munt[] muntTab = new Munt[10];
        muntTab[0] = brPond;
        muntTab[1] = amDollar;
        muntTab[2] = euro;
        muntTab[3] = rusRoebel;
        muntTab[4] = testMunt;
        muntTab[5] = testMunt2;


        System.out.println("overzicht koersen tov de euro 1 Koers = ");
        String formaat = "%10." + Munt.getAfronding() + "f %s%n";
        for (int i = 0; i < Munt.getAantal(); i++){
            System.out.printf(formaat, muntTab[i].getKoers(), muntTab[i].getNaam());
        }

        System.out.println();
        System.out.println("overzicht koersen tov " + muntTab[0].getNaam() + " 1 " + muntTab[0].getNaam() + " =");
        for (int i = 1; i < Munt.getAantal(); i++){
            double res = muntTab[i].getKoers() / muntTab[0].getKoers();
            System.out.printf(formaat, res, muntTab[i].getNaam());
            
        }

    }
}
