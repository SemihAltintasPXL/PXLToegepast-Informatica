package be.pxl.h4.oef2;

public class Trainer {
    private Pokedex pokedex;
    private String naam;

    public Trainer(String naam){
        this.naam = naam;
        pokedex = new Pokedex(10);
    }

    public Pokedex getPokedex() {
        return pokedex;
    }

    public String getNaam() {
        return naam;
    }
    public void vangPokemon(Pokemon pokemon){
        // deze methode wordt allemaal al gecontroleerd in klasse Pokedex
        this.pokedex.voegToe(pokemon);
    }
    public String toString(){
        return naam + "heeft volgende Pokemon gevangen";
    }

}
