package be.pxl.h1.Opdracht10;

public class BankAccount {
    private String naam;
    private String code;
    private int controlDigits;
    private Long number;
    private double amount;


    public void setCode(String code) {
        this.code = code;
    }

    public void setControlDigits(int controlDigits) {
        this.controlDigits = controlDigits;
    }

    public void setNumber(long number) {
        this.number = number;
    }

    public String getAccount(){
        return code + controlDigits + number;
    }
    public boolean isValid(){
        long hulp_getal = number * 1000000 + 111400;
        int mod = (int) (hulp_getal % 97);
        int controle_getal = 98 - mod;

        return (controle_getal == controlDigits);
    }

    public void setAmount(double amount) {
        this.amount = amount;
    }

    public double getAmount() {
        return amount;
    }

    public void withdraw(double amount){
        if (this.amount >= amount) {
            this.amount -= amount;
        }
        else {
            System.out.println("Er staat niet genoeg geld op deze rekening");
        }
    }
}
