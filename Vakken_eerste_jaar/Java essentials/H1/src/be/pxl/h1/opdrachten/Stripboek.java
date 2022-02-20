package be.pxl.h1.opdrachten;

public class Stripboek {

    private String reeks;
    private String titel;
    private int albumNummer;
    private String auteur;

    public String getReeks(){
        return reeks;
    }

    public String getTitel(){
        return titel;
    }

    public String getAuteur(){
        return auteur;
    }
    public int getAlbumNummer(){
        return albumNummer;
    }

    public void setReeks(String reeks) {
        this.reeks = reeks;
    }

    public void setTitel(String titel) {
        this.titel = titel;
    }

    public void setAlbumNummer(int albumNummer) {
        this.albumNummer = albumNummer;
    }

    public void setAuteur(String auteur) {
        this.auteur = auteur;
    }
}
