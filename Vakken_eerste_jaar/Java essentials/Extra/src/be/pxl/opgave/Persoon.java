package be.pxl.opgave;
/* naam: */

import java.util.Objects;

public abstract class Persoon {
    private String id;
    private String naam;

    public Persoon(String id, String naam) {
    StringBuilder sb = new StringBuilder();
    for(Character character : id.toCharArray()) {
        if (Character.isDigit(character)) {
            sb.append(character);
        }
        else if (Character.isAlphabetic(character)) {
            sb.append(Character.toUpperCase(character));
        }
    }
    id = sb.toString();
    if (id.length() > 3)  {
        id = id.substring(0, 3);
        }

    this.id = id;
    this.naam = naam;
}

    public String toString() {
        return "[" + getId() + "] " + getNaam();
    }

    @Override
    public boolean equals(Object object) {
        if (object instanceof be.pxl.opgave.Persoon) {
            if (((be.pxl.opgave.Persoon) object).id.equals(this.id)) {
                return true;
            }
        }
        return false;
    }

    public String getId() {
        return id;
    }

    public String getNaam() {
        return naam;
    }
/*
    @Override
    public int hashCode() {
        return Objects.hash(getId(), getNaam());

    }

 */


}




