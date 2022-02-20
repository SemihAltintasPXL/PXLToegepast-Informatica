package be.pxl.h2.opdracht3;

public class KlasApp {
   public static void main(String[] args) {
       System.out.println(Klasgroep.MAXIMUM_AANTAL_STUDENTEN);

       Klasgroep a = new Klasgroep("1TINa", 35);
       Klasgroep b = new Klasgroep();
       Klasgroep g = new Klasgroep("1TINg", 100);

       Klasgroep[] lijst = {a, b, g};

       for (Klasgroep groep : lijst) {
           System.out.printf("%s (%d studenten)%n",
                   groep.getNaam(), groep.getAantalStudenten());
       }

       System.out.println(Klasgroep.getTeller());
       System.out.println(Klasgroep.getTotaalAantalStudenten());

       a.setAantalStudenten(36);

       System.out.println(Klasgroep.getTotaalAantalStudenten());

       System.out.printf("Gemiddeld: %.1f%n",
               (double) Klasgroep.getTotaalAantalStudenten() / Klasgroep.getTeller());
    }
}
