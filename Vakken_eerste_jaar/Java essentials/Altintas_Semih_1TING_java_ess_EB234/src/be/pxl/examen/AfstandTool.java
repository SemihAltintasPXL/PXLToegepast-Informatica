package be.pxl.examen;

public class AfstandTool {

	/**
	 * Deze methode berekent de afstand tussen de 2 locaties volgens de equirectangular approximation. Voor korte afstanden
	 * is deze berekening ok, maar deze berekening is niet nauwkeurig voor locaties die ver uit elkaar liggen.
	 * @param locatie1 coordinaten van locatie 1
	 * @param locatie2 coordinaten van locatie 2
	 * @return de afstand tussen de 2 locaties uitgedrukt in kilometer.
	 */
	public static double getAfstand(Coordinaten locatie1, Coordinaten locatie2) {
		double lengtegraad1 = locatie1.getLengtegraad();
		double lengtegraad2 = locatie2.getLengtegraad();
		double breedtegraad1 = locatie1.getBreedtegraad();
		double breedtegraad2 = locatie2.getBreedtegraad();
		double x = Math.toRadians(lengtegraad2 - lengtegraad1) * Math.cos(Math.toRadians(breedtegraad1 + breedtegraad2) / 2.0);
		double y = Math.toRadians(breedtegraad2-breedtegraad1);
		return Math.sqrt(x*x + y*y) * 6371;
	}
}
