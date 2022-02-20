package be.pxl.h7.oef1;

public class Kleur {
    private int rood;
    private int groen;
    private int blauw;
    private String hex;

    public Kleur(String hex){
        setHex(hex);
    }
    public Kleur(int rood, int groen, int blauw){
        setRGB(rood, groen, blauw);
    }
    private void hexToRGB(){
        String eerste = hex.substring(1, 3);
        String tweede = hex.substring(3, 5);
        String derde = hex.substring(5, 7);
        int rgb1 = Integer.parseInt(eerste, 16);
        int rgb2 = Integer.parseInt(tweede, 16);
        int rgb3 = Integer.parseInt(derde, 16);
        System.out.printf("(%d, %d, %d)" ,rgb1, rgb2, rgb3);
    }
    private void rgbToHex(){
        String hex = Integer.toHexString(this.rood);
        String hex1 = Integer.toHexString(this.groen);
        String hex2 = Integer.toHexString(this.blauw);
        String resultaat = hex + hex1 + hex2;
        System.out.println(resultaat.toUpperCase());
    }
    public void setHex(String hex){
        char eersteLetter = hex.charAt(0);
        if (!(eersteLetter == '#')){
            System.out.println("Ongeldig hex formaat");
        }
        this.hex = hex;
    }
    public void setRGB(int rood, int groen, int blauw){
        this.rood = rood;
        this.groen = groen;
        this.blauw = blauw;
    }
    public String toString(){
        return hex + " " + "(" + rood + ", " + groen + ", " + blauw + ")";
    }
}
