package be.pxl.opgave;
/* naam: */
// ABSTRACT != OBJECT ***** FINAL != KLASSE
public final class Speler extends Persoon {

    private Sport sport;
    public Speler(String id, String naam, Sport sport) {
        super(id, naam);
        this.sport = sport;

    }

    public Sport getSport() {
        return sport;
    }

    public Speler(String id) {
        this(id,"", null);
    }

    @Override
    public String toString() {
        return super.toString() + "(" + getSport().toString() + ")";
    }


}

