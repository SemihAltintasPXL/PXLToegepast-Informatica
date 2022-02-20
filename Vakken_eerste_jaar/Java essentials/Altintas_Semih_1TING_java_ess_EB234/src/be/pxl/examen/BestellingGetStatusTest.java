package be.pxl.examen;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;
import java.time.LocalDateTime;

public class BestellingGetStatusTest {

	private Klant klant;
	private Restaurant restaurant;
	private Rider rider;
	private Bestelling bestelling;

	@Before
	public void init() {
		klant = new Klant("Owen", "Wilson");
		klant.setAdres(new Adres("Elfde-Liniestraat", 23, 3500, "Hasselt", new double[] {50.93, 5.35}));
		restaurant = new Restaurant("Ribster");
		restaurant.setAdres(new Adres("Binnenweg", 15, 3500, "Hasselt", new double[] {50.94, 5.39}));
		rider = new Rider("Tom", "Hanks", LocalDate.of(2000,3,3));
		bestelling = new Bestelling(klant, restaurant);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
	}

	@Test
	public void geenRiderToegekend() {
		Assert.assertEquals("Nog even geduld aub.", bestelling.getStatus());
	}

	@Test
	public void riderToegekendMaarNogNietGeleverd() {
		bestelling.setRider(rider);
		Assert.assertEquals("Verwachtte levertijd 25/01/2022 12:45", bestelling.getStatus());
	}

	@Test
	public void geleverdeBestelling() {
		bestelling.setRider(rider);
		bestelling.leveren(LocalDateTime.of(2022, 1,25, 12, 42));
		Assert.assertEquals("Bestelling geleverd om 25/01/2022 12:42", bestelling.getStatus());
	}
}
