package be.pxl.extra.project2;

public class BordSpel extends Spel {
    private int speelduur;
    private int aantalSpelers;

    public BordSpel(String naam, Uitgever uitgever){
        super(naam, uitgever);
    }

    public int getSpeelduur() {
        return speelduur;
    }

    public void setSpeelduur(int speelduur) {
        if (speelduur < 0){
            this.speelduur = 30;
        }else{
            this.speelduur = speelduur;
        }
    }

    public int getAantalSpelers() {
        return aantalSpelers;
    }

    public void setAantalSpelers(int aantalSpelers) {
        if (aantalSpelers <0){
            this.aantalSpelers = 1;
        }
        else {
            this.aantalSpelers = aantalSpelers;
        }
    }
    public String toString(){
        return String.format("BordSpel{naam='%s',minimumLeeftijd=%d,uitgever=%s,aantalSpelers='%d',speelduur=%d}",super.getNaam(),super.getMinimumLeeftijd(),super.toString(),aantalSpelers,speelduur);
    }
}
