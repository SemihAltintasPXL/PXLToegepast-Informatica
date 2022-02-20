package be.pxl.h7.oef5;

public enum TShirtSize {
    EXTRA_SMAL(86, "XS"), SMAL(94, "S"), MEDIUM(102, "M"), LARGE(110, "L"), EXTRA_LARGE(118, "XL"), EXTRA_EXTRA_LARGE(128, "XXL"), EXTRA_EXTRA_EXTRA_LARGE(140, "3XL");

    private int borst;
    private String verkorte_notatie;

    private TShirtSize(int borst, String verkorte_notatie) {
        setBorst(borst);
        setVerkorte_notatie(verkorte_notatie);
    }

    public void setBorst(int borst) {
        this.borst = borst;
    }

    public int getBorst() {
        return borst;
    }

    public String getVerkorte_notatie() {
        return verkorte_notatie;
    }

    public void setVerkorte_notatie(String verkorte_notatie) {
        this.verkorte_notatie = verkorte_notatie;
    }

}
