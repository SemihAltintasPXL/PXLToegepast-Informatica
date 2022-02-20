package be.pxl.examen;

public class Persoon {
    private String voornaam;
    private String achternaam;
    private String email;
    private String mobiel;

    public Persoon(String voornaam, String achternaam) {
        this.voornaam = voornaam;
        this.achternaam = achternaam;
    }

    public String getVoornaam() {
        return voornaam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public String getAchternaam() {
        return achternaam;
    }

    public void setAchternaam(String achternaam) {
        this.achternaam = achternaam;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getMobiel() {
        return mobiel;
    }

    public void setMobiel(String mobiel) {
        this.mobiel = mobiel;
    }

    @Override
    public String toString() {
        String resultaat =  voornaam + " " + achternaam;
        if (mobiel != null) {
            resultaat += " (" + mobiel + ")";
        }
        return resultaat;
    }
}
