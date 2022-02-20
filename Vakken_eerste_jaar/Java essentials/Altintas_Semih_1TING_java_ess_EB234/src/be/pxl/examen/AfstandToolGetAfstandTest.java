package be.pxl.examen;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class AfstandToolGetAfstandTest {

	@Test
	public void afstandTussenTweeSteden() {
		Coordinaten coordinaten1 = new Coordinaten(new double[] {50.96, 5.50}); // plaats in Genk
		Coordinaten coordinaten2 = new Coordinaten(new double[] {50.93, 5.33}); // plaats in Hasselt
		assertEquals(12.37, AfstandTool.getAfstand(coordinaten1, coordinaten2), 0.01);
	}

	@Test
	public void afstandBinnenEenStad() {
		Coordinaten coordinaten1 = new Coordinaten(new double[] {50.93, 5.34}); // Hasselt Grote Markt
		Coordinaten coordinaten2 = new Coordinaten(new double[] {50.94, 5.35}); // PXL gebouw G
		assertEquals(1.31, AfstandTool.getAfstand(coordinaten1, coordinaten2), 0.01);
	}
}
