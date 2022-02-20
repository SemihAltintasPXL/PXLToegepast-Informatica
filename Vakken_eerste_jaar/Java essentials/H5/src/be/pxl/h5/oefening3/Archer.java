package be.pxl.h5.oefening3;

import java.util.Random;

public class Archer extends Human{
    private Bow bow;
    public Archer(String naam){
        super(naam);
        setWeapon(new Bow(10, 5));
    }
    public void findArrows(){
        Random random = new Random();
        int aantal_pijlen = random.nextInt(10) + 1;
        bow.addArrows(aantal_pijlen);

    }
    public void attack(Character opponent){
        opponent.decreaseHealth(bow.doDamage());
        speak("Attacking " + opponent.getName() + " with my bow!");
    }

    @Override
    public void setWeapon(Weapon weapon) {
        if (!(weapon instanceof Bow)){
            speak("I only know how to shoot a bow");
        }
        //Dit is wss niet juist
        //In setWeapon moet je het meegegeven weapon ook opslaan in de eigenschap bow (als het een Bow is). Zo niet, dan print je de message die je nu al hebt.
        weapon = bow;
    }
}
