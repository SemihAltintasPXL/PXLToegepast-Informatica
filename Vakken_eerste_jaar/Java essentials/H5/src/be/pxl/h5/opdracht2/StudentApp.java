package be.pxl.h5.opdracht2;

public class StudentApp {
    public static void main(String[] args) {

        Student student = new Student();

        student.setVoornaam("Sam");
        student.setNaam("Vanderstraeten");

        System.out.println(student.getNaam());
        student.print();
    }
}
