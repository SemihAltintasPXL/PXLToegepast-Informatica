package be.pxl.h5.opdracht;

import java.rmi.StubNotFoundException;

public class Student extends Persoon {
    private int leerkrediet;
    private String studentennummer;
    private String opleiding;


    public Student(){
        this("onbekend", "onbekend");
    }
    public Student(String naam, String voornaam){
        super();
    }

    public int getLeerkrediet() {
        return leerkrediet;
    }

    public void setLeerkrediet(int leerkrediet) {
        if (leerkrediet < 0){
            leerkrediet = 0;
        }
        else if (leerkrediet > 140){
            leerkrediet = 140;
        }
        this.leerkrediet = leerkrediet;
    }

    public String getStudentennummer() {
        return studentennummer;
    }
    public void setStudentennummer(String studentennummer) {
        this.studentennummer = studentennummer;
    }

    public String getOpleiding() {
        return opleiding;
    }
    public void setOpleiding(String opleiding) {
        this.opleiding = opleiding;
    }
    public void wijzigLeerkrediet(int verschil){
        setLeerkrediet(this.leerkrediet + verschil);
    }
}
