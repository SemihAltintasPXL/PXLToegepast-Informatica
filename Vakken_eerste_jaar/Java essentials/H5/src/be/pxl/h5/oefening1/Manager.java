package be.pxl.h5.oefening1;

public class Manager extends Werknemer{
    private double bonus;
    private static int aantal;

    public Manager(String naam, String voornaam,String functie, double salaris){
        this(naam, voornaam, functie, salaris, 50);

    }
    public Manager(String naam, String voornaam, String functie, double salaris, double bonus){
        super(naam, voornaam, functie, salaris);
        setBonus(bonus);
        aantal++;
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        this.bonus = bonus;
    }

    @Override
    public double getSalaris() {
        return super.getSalaris() + getBonus();
    }

    public static int getAantal() {
        return aantal;
    }
    public static double getProcAandeelManagers(){
        double perc = ((double) Manager.getAantal() / Werknemer.getAantal()) * 100;
        return Math.round(perc / 100) * 100;

    }
}
