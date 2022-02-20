package be.pxl.examen;

public class Coordinaten {
    private final double breedtegraad;
    private final double lengtegraad;

    public Coordinaten(double breedtegraad, double lengtegraad) {
        this.breedtegraad = breedtegraad;
        this.lengtegraad = lengtegraad;
    }

    public Coordinaten(double[] coordinaten) {
        this(coordinaten[0], coordinaten[1]);
    }

    public double getLengtegraad() {
        return lengtegraad;
    }

    public double getBreedtegraad() {
        return breedtegraad;
    }




}

