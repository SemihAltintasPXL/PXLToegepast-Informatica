package be.pxl.h2.oef2;

public class Bankrekening {
    private String rekeningnummer;
    private String naam_eigenaar;
    private double saldo;
    private double rente;

    public Bankrekening(){
        this("geen", "onbekend", 1.2,0);
    }

    public Bankrekening(String rekeningnummer, String naam_eigenaar, double saldo, double rente){
        setRekeningnummer(rekeningnummer);
        setNaam_eigenaar(naam_eigenaar);
        setSaldo(saldo);
        setRente(rente);
    }

    public String getRekeningnummer() {
        return rekeningnummer;
    }

    public void setRekeningnummer(String rekeningnummer) {
        this.rekeningnummer = rekeningnummer;
    }

    public String getNaam_eigenaar() {
        return naam_eigenaar;
    }

    public void setNaam_eigenaar(String naam_eigenaar) {
        this.naam_eigenaar = naam_eigenaar;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        // je kan ook in plaats van dit te doen een extra methode controle aan maken
        if (saldo < 0){
            saldo = 0;
        }
        this.saldo = saldo;
    }

    public double getRente() {
        return rente;
    }

    public void setRente(double rente) {
        if (rente < 0){
            rente = 0;
        }
        this.rente = rente;
    }
    public void stort(double bedrag){
        if (valideerRekening()) {
            saldo += bedrag;
            System.out.println(" na storting van " + bedrag + " euro");
            print();
        }
    }
    public void neemOp(double bedrag){
        if (valideerRekening()){
            if (saldo == 0){
                System.out.println(" U kan geen geld opnemen");
            }
            else if (bedrag <= saldo){
                saldo -= bedrag;
            }
            else {
                System.out.printf(" U mag enkel %.0f euro opnemen ", saldo);
                saldo = 0;
            }
            System.out.println(" na opname van " + bedrag + " euro");
            print();
        }


    }
    public void doeVerrichting(double[] aantal_verrichtingen){
        if (valideerRekening()){
            for (double verrichting: aantal_verrichtingen){
                if (verrichting > 0){
                    stort(verrichting);
                }
                else {
                    neemOp(verrichting);
                }
            }
        }

    }
    public void schrijfRenteBij(){
        if (valideerRekening()){
            saldo = saldo + (saldo * rente);
        }
    }
    public boolean valideerRekening(){
        if (rekeningnummer.equals("geen")){
            System.out.println(" U hebt geen rekeningnummer ingegeven");
            return false;
        }
        if (naam_eigenaar.equals("onbekend")){
            System.out.println(" U hebt geen naam ingevuld");
            return false;
        }
        return true;
    }
    public void print(){
        System.out.printf("Saldo op spaarrekening %s op naam %s bedraagt %.0f%n", rekeningnummer, naam_eigenaar, saldo);
    }
}
