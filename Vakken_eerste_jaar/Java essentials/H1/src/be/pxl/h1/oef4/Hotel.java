package be.pxl.h1.oef4;

public class Hotel {
    private String hotelcode;
    private int aantal_sterren;
    private char kindercode;

    public String getHotelcode() {
        return hotelcode;
    }

    public void setHotelcode(String hotelcode) {
        this.hotelcode = hotelcode;
    }

    public String getAantal_sterren() {
        String output = "";
        for (int i = 0; i < aantal_sterren; i++){
            output += "*";
        }
        return output;
    }

    public void setAantal_sterren(int aantal_sterren) {
        this.aantal_sterren = aantal_sterren;
    }

    public char getKindercode() {
        return kindercode;
    }

    public void setKindercode(char kindercode) {
        this.kindercode = kindercode;
    }
    public double getPrijs(){
        double prijs;
        if (hotelcode.equals("HI")){
            prijs = 70;
        }
        else if (aantal_sterren == 4 || aantal_sterren == 5){
            prijs = 60;
        }
        else if (aantal_sterren == 3 && hotelcode.equals("BR") || hotelcode.equals("AN")){
            prijs = 60;
        }
        else if (aantal_sterren == 3){
            prijs = 56;
        }
        else {
            prijs = 48;
        }
        return prijs;
    }
    public double getPrijsKind(){
        if (kindercode == ('A')) {
            if (aantal_sterren == 1 || aantal_sterren == 2) {
                return 0;
            }
            else if (hotelcode.equals("HA")){
                return 0;
            }
        }
        return getPrijs() / 2;
    }
}
