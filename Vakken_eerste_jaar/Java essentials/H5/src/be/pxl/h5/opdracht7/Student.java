package be.pxl.h5.opdracht7;

public class Student extends Persoon {
    private static int aantal = 0;
    private String studentenNummer;
    private int leerkrediet;
    private String opleiding;

    public Student() {
        this("onbekend", "onbekend");
    }

    public Student(String naam, String voornaam) {
        this(naam, voornaam, "15999999", "XXX");

    }

    public Student(String naam, String voornaam, String studentenNummer, String opleiding) {
        super(naam, voornaam);
        this.studentenNummer = studentenNummer;
        this.opleiding = opleiding;
        this.leerkrediet = 140;
        aantal++;
    }

    public Student(Student andere) {
        this(andere.getNaam(), andere.getVoornaam(), andere.getStudentenNummer(), andere.getOpleiding());
        this.leerkrediet = andere.getLeerkrediet();
    }

    public static int getAantal() {
        return aantal;
    }

    public String getStudentenNummer() {
        return studentenNummer;
    }

    public void setStudentenNummer(String studentenNummer) {
        this.studentenNummer = studentenNummer;
    }

    public int getLeerkrediet() {
        return leerkrediet;
    }

    public void setLeerkrediet(int leerkrediet) {
        if(leerkrediet < 0) {
            leerkrediet = 0;
        }
        if(leerkrediet > 140) {
            leerkrediet = 140;
        }
        this.leerkrediet = leerkrediet;
    }

    public void wijzigLeerkrediet(int verschil) {
        int nieuwLeerkrediet = leerkrediet + verschil;
        setLeerkrediet(nieuwLeerkrediet);
    }

    public String getOpleiding() {
        return opleiding;
    }

    public void setOpleiding(String opleiding) {
        this.opleiding = opleiding;
    }

    @Override
    public void print() {
        super.print();
        System.out.println("Studentennummer: " + studentenNummer);
        System.out.println("Leerkrediet: " + leerkrediet);
        System.out.println("Opleiding: " + opleiding);
    }
}
