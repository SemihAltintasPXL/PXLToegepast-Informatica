package be.pxl.opgave;
/* naam: */

public final class Scheidsrechter extends Persoon {

    public Scheidsrechter(String id, String naam) {
        super(id, naam);
    }

    public String toString() {
        return super.toString() + " <refs>";
    }
}

