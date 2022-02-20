package be.pxl.examen;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;

public class DeliverooApp {

	public static void main(String[] args) {

		Rider rider = new Rider("Lucy", "Kepner", LocalDate.of(2001, 5, 14));
		rider.setVoertuig(new Fiets());

		Restaurant resto1 = new Restaurant("Luscious Burger", TypeKeuken.FAST_FOOD);
		resto1.setAdres(new Adres("Raamstraat", 14, 3500, "Hasselt", new double[] { 50.93, 5.33 }));
		Restaurant resto2 = new Restaurant("Encantador", TypeKeuken.ITALIAANS);
		resto2.setAdres(new Adres("Klokstraat", 22, 3600, "Genk", new double[] { 50.96, 5.50 }));

		Klant sam = new Klant("Sam", "Vanderstraeten");
		Bestelling order1 = new Bestelling(sam, resto2);
		sam.setAdres(new Adres("Kempische Steenweg", 345, 3500, "Hasselt", new double[] {50.95, 5.35}));
		order1.voegGerechtToe(new Gerecht(2, "Pizza Quatro Stagione"));
		order1.voegGerechtToe(new Gerecht(1, "Pizza Hawaii"));
		order1.setGewensteLevertijd(todayAt("12:20"));

		System.out.println("*".repeat(15));
		System.out.println(order1);
		System.out.println("*".repeat(15));

		System.out.println(order1.getStatus());
		order1.setRider(rider);
		System.out.println(order1.getStatus());
		order1.leveren(todayAt("12:23"));
		System.out.println(order1.getStatus());

		Klant nele = new Klant("Nele", "Custers");
		nele.setMobiel("0412/12.34.56");
		nele.setAdres(new Adres("Elfde-Liniestraat", 23, 3500, "Hasselt", new double[] {50.93, 5.35}));
		Bestelling order2 = new Bestelling(nele, resto1);
		order2.voegGerechtToe(new Gerecht(1, "fish burger"));
		order2.voegGerechtToe(new Gerecht(1, "cheese burger"));
		order2.voegGerechtToe(new Gerecht(1, "cheese burger"));
		order2.voegGerechtToe(new Gerecht(2, "bicky burger"));
		order2.setGewensteLevertijd(todayAt("13:00"));

		System.out.println("*".repeat(15));
		System.out.println(order2);
		System.out.println("*".repeat(15));

		order2.setRider(rider);
		System.out.println(order2.getStatus());
		order2.leveren(todayAt("13:10"));
		System.out.println(order2.getStatus());

		System.out.printf("%s verdiende deze middag €%.2f", rider.getVoornaam(), rider.getBedrag());

	}

	private static LocalDateTime todayAt(String time) {
		String[] split = time.split(":");
		return LocalDateTime.of(LocalDate.now(), LocalTime.of(Integer.parseInt(split[0]), Integer.parseInt(split[1])));
	}

}
