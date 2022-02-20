package be.pxl.examen;

import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;

import static org.junit.Assert.assertEquals;

public class RiderPlusBedragTest {

	private Rider rider;

	@Before
	public void init() {
		rider = new Rider("Daffy", "Duck", LocalDate.of(2000, 3, 11));
	}

	@Test
	public void voegEenBedragToe() {
		rider.plusBedrag(25.5);
		assertEquals(25.5, rider.getBedrag(), 0.01);
	}

	@Test
	public void voegMeedereBedragenToe() {
		rider.plusBedrag(25.5);
		rider.plusBedrag(12.35);
		rider.plusBedrag(7.2);
		assertEquals(45.05, rider.getBedrag(), 0.01);
	}
}
