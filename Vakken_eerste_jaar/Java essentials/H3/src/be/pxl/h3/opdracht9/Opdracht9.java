package be.pxl.h3.opdracht9;

import java.util.ArrayList;

public class Opdracht9 {
    public static void main(String[] args) {
        ArrayList<String> lijst = new ArrayList<>();

        lijst.add("Sam");
        lijst.add("BErt");
        lijst.add(1, "jos");
        lijst.set(2, "Gerda");
        lijst.remove("Sam");

        for(String s : lijst) {
            System.out.println(s);
        }

        lijst.clear();
    }
}
