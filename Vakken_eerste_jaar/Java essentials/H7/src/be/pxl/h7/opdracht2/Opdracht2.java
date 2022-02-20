package be.pxl.h7.opdracht2;

import java.math.BigInteger;

public class Opdracht2 {
    public static void main(String[] args) {
        System.out.println(faculteit(1000));
    }

    public static BigInteger faculteit(int n) {
        BigInteger result = new BigInteger("1");
        for(int i=n;i>0;i--) {
            result = result.multiply(new BigInteger(String.valueOf(i)));
        }
        return result;
    }
}
