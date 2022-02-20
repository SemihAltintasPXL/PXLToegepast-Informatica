package be.pxl.h1.oef2;

public class Zwembad {
    private double lengte;
    private double breedte;
    private double diepte;

    public void setLengte(double lengte) {
        this.lengte = lengte;
    }

    public void setBreedte(double breedte) {
        this.breedte = breedte;
    }

    public void setDiepte(double diepte) {
        this.diepte = diepte;
    }
    // ik zet hier  * 1000 zodat het niet bij de onderstaande 2 moet
    public double getVolume(){
        return lengte * breedte * diepte * 1000;
    }
    public double getVolumeWater(){
        return getVolume() * 0.98;
    }
    public double getVolumeOntsmettingsmiddel(){
        return getVolume() * 0.02;
    }
}
