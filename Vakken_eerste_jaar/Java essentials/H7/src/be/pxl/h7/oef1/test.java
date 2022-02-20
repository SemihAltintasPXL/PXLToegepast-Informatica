package be.pxl.h7.oef1;

import java.awt.*;
import java.util.Locale;

public class test {
    public static void main(String[] args) {
        String hex = "#fffff0";
        /*
        System.out.println(Color.decode(hex));
        String hexadecimaal = Integer.toHexString(124);
        String hexadecimaal1 = Integer.toHexString(252);
        String hexadecimaal2 = Integer.toHexString(0);
        String resultaat = hexadecimaal + hexadecimaal1 + hexadecimaal2;
        System.out.println(hexadecimaal);
        System.out.println(hexadecimaal1);
        System.out.println(hexadecimaal2);
        System.out.println(resultaat.toUpperCase());
*/
        String eerste = hex.substring(1, 3);
        String tweede = hex.substring(3, 5);
        String derde = hex.substring(5, 7);
        int rgb1 = Integer.parseInt(eerste, 16);
        int rgb2 = Integer.parseInt(tweede, 16);
        int rgb3 = Integer.parseInt(derde, 16);

        System.out.printf("(%d, %d, %d)" ,rgb1, rgb2, rgb3);
    }
}
