package be.pxl.h5.opdracht7;

public class Lector extends Persoon {
    private static int aantal = 0;
    private String personeelsnummer;
    private int aanstellingsPercentage;
    private double salaris;

    public Lector() {
        this("onbekend", "onbekend", 100, 2000);
    }

    public Lector(String naam, String voornaam, int aanstellingsPercentage, double salaris) {
        this(naam, voornaam, "20009999", aanstellingsPercentage, salaris);
    }

    public Lector(String naam, String voornaam, String personeelsnummer, int aanstellingsPercentage, double salaris) {
        super(naam, voornaam);
        this.personeelsnummer = personeelsnummer;
        setAanstellingsPercentage(aanstellingsPercentage);
        this.salaris = salaris;
        aantal++;
    }

    public static int getAantal() {
        return aantal;
    }

    public String getPersoneelsnummer() {
        return personeelsnummer;
    }

    public void setPersoneelsnummer(String personeelsnummer) {
        this.personeelsnummer = personeelsnummer;
    }

    public int getAanstellingsPercentage() {
        return aanstellingsPercentage;
    }

    public void setAanstellingsPercentage(int aanstellingsPercentage) {
        if(aanstellingsPercentage < 0) {
            aanstellingsPercentage = 0;
        }
        if(aanstellingsPercentage > 100) {
            aanstellingsPercentage = 100;
        }
        /*aanstellingsPercentage = Math.max(0, aanstellingsPercentage);
        aanstellingsPercentage = Math.min(100, aanstellingsPercentage);*/

        if(this.aanstellingsPercentage > 0 && this.salaris > 0) {
            double nieuwSalaris = (this.salaris / this.aanstellingsPercentage) * aanstellingsPercentage;
            setSalaris(nieuwSalaris);
        }

        this.aanstellingsPercentage = aanstellingsPercentage;
    }

    public double getSalaris() {
        return salaris;
    }

    public void setSalaris(double salaris) {
        this.salaris = salaris;
    }

    @Override
    public void print() {
        super.print();
        System.out.println("Personeelsnummer: " + personeelsnummer);
        System.out.println("Salaris: " + salaris);
        System.out.println("Aanstellingspercentage: " + aanstellingsPercentage);
    }
}
