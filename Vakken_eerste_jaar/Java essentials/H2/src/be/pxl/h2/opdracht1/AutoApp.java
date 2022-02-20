package be.pxl.h2.opdracht1;

public class AutoApp {
    public static void main(String[] args) {
        Auto wagen = new Auto("rood", "Tesla", 5);
        Auto wagen2 = new Auto("blauw", "Ford", 3, -15000);
        Auto wagen3 = new Auto(wagen2);

        System.out.println(wagen.getKleur());
        System.out.println(wagen2.getKilometerStand());
        System.out.println(wagen3.getKilometerStand());

    }
}
