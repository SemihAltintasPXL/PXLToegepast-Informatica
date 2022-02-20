package be.pxl.examen;

import java.util.Objects;

public class Gerecht {
    private int aantal;
    private String naam;

    public Gerecht(int aantal, String naam) {
        this.aantal = aantal;
        this.naam = naam;
    }

    public int getAantal() {
        return aantal;
    }

    public String getNaam() {
        return naam;
    }
    public void voegToe(int aantal){
        this.aantal += aantal;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Gerecht gerecht = (Gerecht) o;
        return Objects.equals(naam, gerecht.naam);
    }
    @Override
    public int hashCode() {
        return Objects.hash(naam);
    }
    public String toString(){
        return getAantal() + " x " + getNaam();
    }
}
