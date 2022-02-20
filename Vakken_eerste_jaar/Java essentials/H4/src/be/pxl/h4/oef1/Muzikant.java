package be.pxl.h4.oef1;

public class Muzikant {
    private String naam;
    private Instrument instrument;

    public Muzikant(String naam, Instrument instrument){
        this.naam = naam;
        setInstrument(instrument);
    }

    public void setInstrument(Instrument instrument) {
        this.instrument = instrument;
    }
    public void speel(){
        this.instrument.speel();
    }
    public String toString(){
        return naam + "[" +  this.instrument.toString() + "]";
    }
}
