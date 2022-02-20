package be.pxl.h7.oef1;

public class FileSystem {
    public static void main(String[] args) {
        TekstBestand tekstBestand = new TekstBestand("Hello World!");
        TekstBestand tekstBestand1 = new TekstBestand("Hello Dunya!");

        TekstBestand[] bestanden = {tekstBestand, tekstBestand1};
        int[] array = {4, 8};
        Afbeelding afbeelding = new Afbeelding("Hello World!", array);
        Folder folder = new Folder("Mijn Documenten");
        folder.voegBestandenToe(bestanden);

        folder.voeruit();
    }
}
