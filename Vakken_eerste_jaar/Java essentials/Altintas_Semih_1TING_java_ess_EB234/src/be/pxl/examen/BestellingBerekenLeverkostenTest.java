package be.pxl.examen;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;
import java.time.LocalDateTime;

public class BestellingBerekenLeverkostenTest {

	private Klant klant;
	private Restaurant restaurant;
	private Rider rider;

	@Before
	public void init() {
		klant = new Klant("Owen", "Wilson");
		klant.setAdres(new Adres("Elfde-Liniestraat", 23, 3500, "Hasselt", new double[] {50.93, 5.35}));
		restaurant = new Restaurant("Ribster");
		restaurant.setAdres(new Adres("Binnenweg", 15, 3500, "Hasselt", new double[] {50.94, 5.39}));
		rider = new Rider("Tom", "Hanks", LocalDate.of(2000,3,3));
	}

	@Test
	public void riderMetFietsEnOpTijd() {
		rider.setVoertuig(new Fiets());
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,12,47));
		Assert.assertEquals(4.25, bestelling.berekenLeverkosten(), 0.01);
	}

	@Test
	public void riderMetScooterEnOpTijd() {
		rider.setVoertuig(new Scooter("0123456789"));
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,12,47));
		Assert.assertEquals(3.95, bestelling.berekenLeverkosten(), 0.01);
	}

	@Test
	public void riderMetFietsEnTeLaat() {
		rider.setVoertuig(new Fiets());
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,12,55));
		Assert.assertEquals(4.08, bestelling.berekenLeverkosten(), 0.01);
	}

	@Test
	public void riderMetScooterEnTeLaat() {
		rider.setVoertuig(new Scooter("0123456789"));
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,12,55));
		Assert.assertEquals(3.79, bestelling.berekenLeverkosten(), 0.01);
	}

	@Test
	public void riderMetFietsEnVeelTeLaat() {
		rider.setVoertuig(new Fiets());
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,13,12));
		Assert.assertEquals(3.83, bestelling.berekenLeverkosten(), 0.01);
	}

	@Test
	public void riderMetScooterEnVeelTeLaat() {
		rider.setVoertuig(new Scooter("0123456789"));
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.setRider(rider);
		bestelling.setGewensteLevertijd(LocalDateTime.of(2022, 1,25,12,45));
		bestelling.leveren(LocalDateTime.of(2022, 1,25,13,12));
		Assert.assertEquals(3.56, bestelling.berekenLeverkosten(), 0.01);
	}

}
