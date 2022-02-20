package be.pxl.h4.oef4;

public class Gemeente {
    private int postcode;
    private String gemeentenaam;

    public Gemeente(int postcode, String gemeentenaam){
        setPostcode(postcode);
        setGemeentenaam(gemeentenaam);
    }

    public int getPostcode() {
        return postcode;
    }

    public void setPostcode(int postcode) {
        while (postcode < 1000){
            postcode *= 10;
        }
        while (postcode > 9999){
            postcode /= 10;
        }
        this.postcode = postcode;
    }

    public String getGemeenteNaam() {
        return gemeentenaam;
    }

    public void setGemeentenaam(String gemeentenaam) {
        this.gemeentenaam = gemeentenaam;
    }
    public String toString(){
        return getPostcode() + " " + getGemeenteNaam();
    }
}
