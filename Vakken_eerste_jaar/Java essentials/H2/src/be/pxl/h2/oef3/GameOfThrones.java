package be.pxl.h2.oef3;

public class GameOfThrones {

    public static void main(String[] args) {
        Character littlefinger = new Character("Petyr", "Baelish", "Littlefinger", "Baelish", "Aidan Gillen");

        Character tyrion = new Character("Tyrion", "Lannister", "The Imp", "Lannister", 1, 8, 67, "Peter Dinklage");
        tyrion.addTitle("Hand of the King");
        tyrion.addTitle("Warden of the West");
        tyrion.addTitle("Lord of Caterly Rock");

        Character catelyn = new Character("Catelyn", "Stark", "Tully", "Michelle Fairley");
        catelyn.setData(1, 3, 26);

        Character sam = new Character("Samwell", "Tarly", "Sam", "Tarly", 1, 8, 48, "John Bradley");
        sam.addTitle("Grand Maester");

        Character margaery = new Character("Margaery", "Tyrell", "Tyrell", "Nathalie Dormer");
        margaery.addTitle("Queen Consort");
        margaery.setData(2, 6, 26);

        System.out.println(littlefinger);
        System.out.println();
        System.out.println(tyrion);
        System.out.println();
        System.out.println(catelyn);
        System.out.println();
        System.out.println(sam);
        System.out.println();
        System.out.println(margaery);
        System.out.println();
        System.out.println(Character.getCount() + " characters geregistreerd");
    }

}
