package be.pxl.h7.demo;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.ArrayList;

public class Demo {
    public static void main(String[] args) {
        LocalDate datum = LocalDate.now();
        System.out.println(datum);

        LocalDate datum2 = LocalDate.of(2018,5,2);

        LocalTime tijd = LocalTime.of(12,0,0);

        LocalDateTime tijdstip = LocalDateTime.of(2020,2,20,20,00,00);
        System.out.println(tijdstip);
    }
}
