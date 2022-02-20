package be.pxl.h1.opdracht9;

import java.util.Scanner;

public class ThermometerApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Thermometer thermometer = new Thermometer();
        System.out.print("geef de graden in celcius in: ");
        double temperatuur_in_celcius = scanner.nextDouble();
        thermometer.setTemperature(temperatuur_in_celcius);

        System.out.println("C: " + thermometer.getTemperature());
        System.out.println("F: " + thermometer.getFahrenheit());
        scanner.close();

        for (int i = -10; i <= 25; i+=5){
            thermometer.setTemperature(i);
            System.out.printf("|%10.2f|%10.2f|%n", thermometer.getTemperature(), thermometer.getFahrenheit());
        }
    }

}
