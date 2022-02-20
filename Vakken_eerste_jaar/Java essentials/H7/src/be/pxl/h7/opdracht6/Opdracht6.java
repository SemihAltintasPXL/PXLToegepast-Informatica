package be.pxl.h7.opdracht6;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class Opdracht6 {
    public static void main(String[] args) {

        String s = "03/04/1999";
        DateTimeFormatter parser = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        LocalDate datum = LocalDate.parse(s, parser);

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
        System.out.println(formatter.format(datum));
    }
}
