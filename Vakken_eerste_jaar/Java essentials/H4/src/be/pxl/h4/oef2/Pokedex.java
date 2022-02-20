package be.pxl.h4.oef2;

import java.util.ArrayList;

public class Pokedex {
    private ArrayList<Pokemon> pokemon;


    public Pokedex(int grootte){
        pokemon = new ArrayList<>(grootte);
    }

    public ArrayList<Pokemon> getPokemon() {
        return pokemon;
    }

    public boolean bevat(Pokemon pokemon){
        for(Pokemon p: this.pokemon){
            if (p != null && pokemon.getNaam().equals(p.getNaam())){
                return true;
            }
        }
        return false;
    }
    public void voegToe(Pokemon pokemon){
        if (!bevat(pokemon)){
            this.pokemon.add(pokemon);
        }
    }
    public String toString(){
        StringBuilder stringBuilder = new StringBuilder();
        for (Pokemon p: this.pokemon){
            stringBuilder.append(p.toString());
        }
        return stringBuilder.toString();
    }
}
