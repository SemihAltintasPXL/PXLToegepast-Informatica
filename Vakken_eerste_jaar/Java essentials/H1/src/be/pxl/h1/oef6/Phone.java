package be.pxl.h1.oef6;

public class Phone {
    private String number;
    private String provider;
    private int numberOfCalls;
    private int numberOfFreeCalls;

    private void call(String telefoonnummer){
        double prijs;
        int aantal_telefoontjes = 0;
        if (telefoonnummer.equals("112") || telefoonnummer.equals("102") || telefoonnummer.equals("070245245")){
            prijs = 0;
        }
        else if (provider.equals("floximus")){
            prijs = 0.25;
            aantal_telefoontjes++;
        }
        
    }
}
