package be.pxl.h5.oefening1;

public class Werknemer extends Persoon{
    private String functie;
    private double salaris;
    private static final int MINSALARIS = 1000;
    private static int aantal = 0;

    public Werknemer(String naam, String voornaam) {
        this(naam, voornaam,"algemeen bediende", 1800);
    }

    public Werknemer(String naam, String voornaam, String functie, double salaris) {
        super(naam, voornaam);
        setFunctie(functie);
        setSalaris(salaris);
        aantal++;
    }

    public String getFunctie() {
        return functie;
    }

    public void setFunctie(String functie) {
        this.functie = functie;
    }

    public double getSalaris() {
        return salaris;
    }

    public void setSalaris(double salaris) {
        if (salaris < Werknemer.MINSALARIS) {
            salaris = Werknemer.MINSALARIS;
        }
        this.salaris = salaris;
    }

    @Override
    public void print() {
        super.print();
        System.out.println("Salaris: " + this.salaris);
        System.out.println("Functie: " + this.functie);
    }

    public static int getMinimumSalaris() {
        return MINSALARIS;
    }

    public static int getAantal() {
        return aantal;
    }
}
