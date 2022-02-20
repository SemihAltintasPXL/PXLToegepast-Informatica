package be.pxl.h1.oef5;

public class SpaceshipApp {
    public static void main(String[] args) {
        Spaceship spaceship1 = new Spaceship();
        Spaceship spaceship2 = new Spaceship();

        spaceship1.setName("BS Galactica");
        spaceship2.setName("STS Shade");
        spaceship1.fire(spaceship2);
        spaceship2.fire(spaceship1);
        spaceship1.setShieldOn(true);
        spaceship2.fire(spaceship1);
        spaceship1.fire(spaceship2);
        spaceship1.fire(spaceship2);
        spaceship1.fire(spaceship2);
        spaceship1.fire(spaceship2);
        System.out.println(spaceship1.getName() + " is destroyed? " + spaceship1.isDestroyed());
        System.out.println(spaceship2.getName() + " is destroyed? " + spaceship2.isDestroyed());

    }
}
