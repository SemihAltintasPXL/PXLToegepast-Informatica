package be.pxl.h8.oef2;

public class GewapendeBoei extends ZeeObject{
    private int bereik;
    private int schade;


    public GewapendeBoei(int x, int y, Alliantie alliantie, int levenspunten, int bereik, int schade) {
        super(x, y, alliantie, levenspunten);
        this.bereik = bereik;
        this.schade = schade;
    }
    public void doeSchade(ZeeObject zeeObject){
        if (getLevenspunten() > 0 && (!getAlliantie().equals(zeeObject.getAlliantie())) && getLocatie().berekenAfstand(zeeObject.getLocatie()) <= bereik){
            zeeObject.ontvangSchade(schade);
        }
    }
    @Override
    public String toString(){
        return super.toString() + " " + bereik + " " + schade;
    }

}
