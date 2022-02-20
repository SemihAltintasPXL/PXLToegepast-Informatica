package be.pxl.h1.oef4;

import java.util.Scanner;

public class HotelApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Hotel hotel = new Hotel();
        System.out.print("Geef het aantal volwassenen in: ");
        int aantal_volwassenen = scanner.nextInt();
        System.out.print("Geef het aantal kinderen in: ");
        int aantal_kinderen = scanner.nextInt();
        scanner.nextLine();
        double totaalprijs = 0;
        StringBuilder output = new StringBuilder();

        System.out.print("Geef een hotelcode: ");
        String hotelcode = scanner.nextLine();
        hotel.setHotelcode(hotelcode);
        while (!(hotelcode.equals("/"))){
            System.out.print("Geef het aantal sterren in: ");
            int aantal_sterren = scanner.nextInt();
            hotel.setAantal_sterren(aantal_sterren);
            scanner.nextLine();
            System.out.print("Geef het kindercode in: ");
            char kindercode = scanner.nextLine().charAt(0);
            hotel.setKindercode(kindercode);
            while (hotel.getKindercode() < 'A' && hotel.getKindercode() > 'Z'){
                System.out.println("Foute invoer, geef opnieuw de kindercode in:");
                kindercode = scanner.nextLine().charAt(0);
                hotel.setKindercode(kindercode);
            }
            totaalprijs = aantal_volwassenen * hotel.getPrijs() + aantal_kinderen * hotel.getPrijsKind();


            output.append(hotel.getHotelcode() + hotel.getAantal_sterren() + hotel.getPrijs() + hotel.getPrijsKind() + totaalprijs + "\n");
            System.out.print("Geef een hotelcode: ");
            hotelcode = scanner.nextLine();
            if (!hotelcode.equals("/")){
                hotel.setHotelcode(hotelcode);
            }
        }
        System.out.print(output);

    }
}
