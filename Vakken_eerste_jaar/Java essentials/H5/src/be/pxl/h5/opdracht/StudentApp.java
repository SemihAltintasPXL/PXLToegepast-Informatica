package be.pxl.h5.opdracht;

public class StudentApp {
    public static void main(String[] args) {

        Student student = new Student();

        student.setVoornaam("Sam");
        student.setNaam("Vanderstraeten");

        System.out.println(student.getNaam());
        student.print();
        student.setLeerkrediet(-100);
        System.out.println(student.getLeerkrediet());

        student.setLeerkrediet(120);
        System.out.println(student.getLeerkrediet());

        student.wijzigLeerkrediet(100);
        System.out.println(student.getLeerkrediet());

        Lector lector = new Lector();
        lector.setVoornaam("Arno");
        lector.setNaam("Barzan");
        lector.setPersoneelsnummer("234567");
        lector.setSalaris(10000);
        lector.setAanstellingsPercentage(150);
        lector.print();
        lector.setAanstellingsPercentage(100);
        lector.print();
    }
}
