package be.pxl.h6.oef1;

public enum Munt {
    TWEE_EURO(200), EEN_EURO(100), VIJFTIG_CENT(50), TWINTIG_CENT(20), TIEN_CENT(10), VIJF_CENT(5), TWEE_CENT(2), EEN_CENT(1);

    private int waarde;
    private Munt(int d) {
        waarde = d;
    }
    public int getWaarde() {
        return waarde;
    }
    //niet echt nodig
    public String toString(){
        return name().toLowerCase();
    }

}
