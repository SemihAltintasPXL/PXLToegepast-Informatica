package be.pxl.examen;

import org.junit.Before;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.assertEquals;

public class BestellingVoegGerechtToeTest {

	private Klant klant;
	private Restaurant restaurant;

	@Before
	public void init() {
		klant = new Klant("Owen", "Wilson");
		restaurant = new Restaurant("Ribster");
	}

	@Test
	public void voegBestaandGerechtToe() {
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.voegGerechtToe(new Gerecht(2, "Fishsticks"));
		bestelling.voegGerechtToe(new Gerecht(3, "Fishsticks"));
		List<Gerecht> gerechten = bestelling.getGerechten();
		assertEquals(1, gerechten.size());
		assertEquals(new Gerecht(5, "Fishsticks"), gerechten.get(0));
	}

	@Test
	public void voegNieuwGerechtToe() {
		Bestelling bestelling = new Bestelling(klant, restaurant);
		bestelling.voegGerechtToe(new Gerecht(2, "Fishsticks"));
		bestelling.voegGerechtToe(new Gerecht(3, "Rumsteak"));
		List<Gerecht> gerechten = bestelling.getGerechten();
		assertEquals(2, gerechten.size());
	}
}
