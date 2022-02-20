package be.pxl.h5.opdracht7;

import java.util.ArrayList;

public class StudentApp {
    public static void main(String[] args) {
        Student student = new Student("Vanderstraeten", "Sam");
        student.print();

        Lector lector = new Lector("Barzan", "Arno", 150, 10000);
        lector.print();

        Student s2 = new Student("Naam", "Voornaam", "5555", "TIN");
        Student s3 = new Student(s2);

        lector.setAanstellingsPercentage(75);
        lector.print();

        System.out.println(Persoon.getAantal());
        System.out.println(Student.getAantal());
        System.out.println(Lector.getAantal());
    }
}
