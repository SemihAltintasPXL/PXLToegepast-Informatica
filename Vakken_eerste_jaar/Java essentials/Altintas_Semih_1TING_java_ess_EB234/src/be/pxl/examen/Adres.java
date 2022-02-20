package be.pxl.examen;

public class Adres {
    private String straat;
    private int nummer;
    private int postcode;
    private String gemeente;
    private Coordinaten coordinaten;

    public Adres(String straat, int nummer, int postcode, String gemeente, double[] coordinaten) {
        this.straat = straat;
        this.nummer = nummer;
        this.postcode = postcode;
        this.gemeente = gemeente;
        this.coordinaten = new Coordinaten(coordinaten);
    }

    public Coordinaten getCoordinaten() {
        return coordinaten;
    }

    public String getStraat() {
        return straat;
    }

    public int getNummer() {
        return nummer;
    }

    public int getPostcode() {
        return postcode;
    }

    @Override
    public String toString() {
        StringBuilder builder = new StringBuilder();
        builder.append(straat).append(" ").append(nummer).append("\n");
        builder.append(postcode).append(" ").append(gemeente).append("\n");
        return builder.toString();
    }
}
