package be.pxl.h3.oef3;

public class GondelbaanApp {
    public static void main(String[] args) {
        Gondelbaan gondelbaan = new Gondelbaan("aiGuille du MIDI", "Frankrijk", 5.093, 7);
        gondelbaan.setHoogte(3465,3787);
        gondelbaan.setPassagiersPerGondel(4);
        gondelbaan.setAantalGondels(12)    ;
        System.out.println(gondelbaan);
        System.out.printf("duur ongeveer %.2f minuten %n", gondelbaan.getDuur());
        System.out.printf("aantal passagiers per uur %d%n", gondelbaan.getVervoerscapaciteit());
        System.out.println();

        Gondelbaan gondelbaan1 = new Gondelbaan("amsterdam", "Nederland", 5.093, 7);
        System.out.println(gondelbaan1.getLand());
        System.out.println(gondelbaan);
    }

}
