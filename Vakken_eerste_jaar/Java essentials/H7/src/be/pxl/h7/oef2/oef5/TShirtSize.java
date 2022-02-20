package be.pxl.h7.oef2.oef5;

public enum TShirtSize {
    EXTRA_SMAL(86, "XS"), SMAL(94, "S"), MEDIUM(102, "M"), LARGE(110, "L"), EXTRA_LARGE(118, "XL"), EXTRA_EXTRA_LARGE(128, "XXL"), EXTRA_EXTRA_EXTRA_LARGE(140, "3XL");

    private int borstomtrek;
    private String verkorteNotatie;

    TShirtSize(int borstomtrek, String verkorteNotatie) {
        this.borstomtrek = borstomtrek;
        this.verkorteNotatie = verkorteNotatie;
    }

    public int getBorstomtrek() {
        return borstomtrek;
    }

    public String getVerkorteNotatie() {
        return verkorteNotatie;
    }
}
