package be.pxl.h4.oef1;

public class Instrument {
    private String naam;
    private String geluid;


    public Instrument(String naam, String geluid){
        this.naam = naam;
        this.geluid = geluid;
    }
    public void speel(){
        System.out.println(this.geluid);
    }
    public String toString(){
        return this.naam;
    }
}
