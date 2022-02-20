package be.pxl.examen;

public final class Restaurant {
    private String naam;
    private TypeKeuken typeKeuken;
    private Adres adres;

    public Restaurant(String naam) {
        this(naam, TypeKeuken.FAST_FOOD);
    }
    public Restaurant(String naam, TypeKeuken typeKeuken) {
        this.naam = naam;
        this.typeKeuken = typeKeuken;
    }

    public String getNaam() {
        return naam;
    }

    public TypeKeuken getTypeKeuken() {
        return typeKeuken;
    }

    public Adres getAdres() {
        return adres;
    }

    public void setAdres(Adres adres) {
        this.adres = adres;
    }

    public String toString(){
        return getNaam();
    }
}
