package be.pxl.h4.oef1;

public class BandApp {
    public static void main(String[] args) {
        Instrument trompet = new Instrument("trompet", "toet");
        Instrument drum = new Instrument("Drum", "boenk");
        Instrument gitaar = new Instrument("gitaar", "ploing");
        Instrument triangel = new Instrument("triangel", "ting");

        trompet.speel();
        System.out.println(trompet.toString());

        Muzikant muzikant = new Muzikant("Sam", trompet);
        Muzikant muzikant1 = new Muzikant("Jos", drum);
        Muzikant muzikant2 = new Muzikant("Gerda", gitaar);
        Muzikant muzikant3 = new Muzikant("Tom", triangel);

        Muzikant[] leden = {muzikant, muzikant1, muzikant2, muzikant3};

        Band band = new Band("PXL Band", leden);
        band.speel(20);
        System.out.println(band);
    }
}
