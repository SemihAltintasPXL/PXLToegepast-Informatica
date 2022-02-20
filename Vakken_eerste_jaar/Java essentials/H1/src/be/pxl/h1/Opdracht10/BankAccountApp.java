package be.pxl.h1.Opdracht10;

import java.util.Scanner;

public class BankAccountApp {
    public static void main(String[] args) {
        BankAccount bankAccountNumber = new BankAccount();
        Scanner scanner = new Scanner(System.in);
        /*
        bankAccountNumber.setCode("BE");
        bankAccountNumber.setControlDigits(68);
        bankAccountNumber.setNumber(539007547034L);
        System.out.println(bankAccountNumber.getAccount());
        System.out.println("Valid! " + bankAccountNumber.isValid());
        */
        System.out.println("Geef het startbedrag: ");
        double startbedrag = scanner.nextDouble();
        scanner.nextLine();
        bankAccountNumber.setAmount(startbedrag);

        System.out.println("Wil je geld afhalen (J/N) ?");
        String afhalen = scanner.nextLine();

        while(afhalen.equals("J") && bankAccountNumber.getAmount() > 0){
            System.out.printf("Hoeveel geld wil je afhalen (%.1f) \n", bankAccountNumber.getAmount());
            double bedrag = scanner.nextDouble();
            scanner.nextLine();
            bankAccountNumber.withdraw(bedrag);

            if (bankAccountNumber.getAmount() > 0) {
                System.out.println("Wil je geld afhalen (J/N) ?");
                afhalen = scanner.nextLine();
            }

        }
        System.out.printf("Resterende bedrag: %.2f euro%n ", bankAccountNumber.getAmount());
        scanner.close();

    }
}
