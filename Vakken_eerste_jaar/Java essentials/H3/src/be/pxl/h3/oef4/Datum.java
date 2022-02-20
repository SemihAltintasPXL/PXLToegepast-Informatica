package be.pxl.h3.oef4;

public class Datum {
    private int dag;
    private int maand;
    private int jaar;
    private static String[] maandNamen = {"januari", "februari", "maart", "april","mei", "juni", "juli", "augustus", "september", "oktober","november","december"};

    
    public Datum(){
        this(1,1,2020);
    }
    public Datum(int d, int m, int j){
        setDag(d);
        setMaand(m);
        setJaar(j);
    }
    public Datum(Datum bestaandeDatum){
        this(bestaandeDatum.dag, bestaandeDatum.maand, bestaandeDatum.dag);
    }

    public void setDag(int dag) {
        this.dag = dag;
    }

    public void setMaand(int m) {
        if(m < 1){
            m = 1;
        }else if (m > maandNamen.length){
            m = maandNamen.length;
        }
        this.maand = m;
    }

    public void setJaar(int jaar) {
        this.jaar = jaar;
    }

    public int getDag() {
        return dag;
    }

    public int getMaandNr() {
        return maand;
    }
    public String getMaandNaam(){
        return maandNamen[maand - 1];
    }

    public int getJaar() {
        return jaar;
    }
    public String toString(){
        return getDag() + " " + getMaandNaam() + " " + getJaar();
    }
}
