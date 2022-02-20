package be.pxl.h8.oef2;

import java.util.ArrayList;

public class Spel {
    private ArrayList<ZeeObject> zeeObjects;

    public Spel(){
        zeeObjects = new ArrayList<>();
    }
    public void voegZeeObjectToe(ZeeObject zeeObject){
        zeeObjects.add(zeeObject);
    }

    public void beweegZeeObject(int index, Punt punt){
        if (zeeObjects.get(index) instanceof Beweegbaar){
            ((Beweegbaar) zeeObjects.get(index)).beweegNaar(punt);
        }
    }
    public void vuur(){
        for (ZeeObject z : zeeObjects) {
            if (z instanceof GewapendeBoei) {
                for (ZeeObject z1 : zeeObjects) {
                    if (z1 != z) {
                        ((GewapendeBoei) z).doeSchade(z1);
                    }
                }
            }
        }
    }
    public int getAantalZeeObjecten() {
        return zeeObjects.size();
    }

    public void printStatus() {
        for (ZeeObject z : zeeObjects) {
            System.out.println(z.toString());
        }
    }

}
