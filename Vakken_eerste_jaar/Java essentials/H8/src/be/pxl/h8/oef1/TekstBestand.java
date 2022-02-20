package be.pxl.h7.oef1;

public class TekstBestand extends Bestand{

    public TekstBestand(String inhoud) {
        super(inhoud);
        setBestandsGrootte(inhoud.length());
    }
    @Override
    public void voeruit() {
        System.out.println(getNaam().toUpperCase() + "\n" + getInhoud());
    }
}
