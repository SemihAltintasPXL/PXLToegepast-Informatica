package be.pxl.h3.opdracht7;

public class Opdracht7 {
    public static void main(String[] args) {
        String code = "68yy";

        for(int i=0;i<code.length();i++) {
            char c = code.charAt(i);

            if(i==0 || i==1) {
                if(!Character.isAlphabetic(c)) {
                    System.out.println("Eerste twee moeten letter zijn");
                }
            } else {
                if(!Character.isDigit(c)) {
                    System.out.println("Laatste twee moeten cijfer zijn");
                }
            }
        }
    }
}
