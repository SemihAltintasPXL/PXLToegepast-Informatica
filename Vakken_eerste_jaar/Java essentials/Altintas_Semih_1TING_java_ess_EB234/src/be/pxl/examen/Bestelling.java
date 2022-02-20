package be.pxl.examen;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.ArrayList;

public class Bestelling implements Leverbaar{
    private Klant klant;
    private Restaurant restaurant;
    private Rider rider;
    private ArrayList<Gerecht> gerechten = new ArrayList<>();
    private LocalDateTime gewensteLevertijd;
    private LocalDateTime levertijd;

    public Bestelling(Klant klant, Restaurant restaurant) {
        this.klant = klant;
        this.restaurant = restaurant;
    }
    // de getter staat niet in het uml schema maar wel in het tekst
    public Rider getRider() {
        return rider;
    }

    public void setRider(Rider rider) {
        this.rider = rider;
    }

    public void voegGerechtToe(Gerecht gerecht){
        int aantal = 0;
        gerechten.add(gerecht);
        for (Gerecht gerecht1: gerechten){
            if (gerecht != gerecht1){
                gerechten.remove(gerecht);
                aantal++;
            }
        }
        gerecht.voegToe(aantal);

    }
    public ArrayList<Gerecht> getGerechten() {
        return gerechten;
    }

    @Override
    public double berekenLeverkosten() {
        double vasteVergoeding = 3.5;
        if (rider.getVoertuig() instanceof Fiets){
            vasteVergoeding = vasteVergoeding + (0.25 * AfstandTool.getAfstand(restaurant.getAdres().getCoordinaten(), klant.getAdres().getCoordinaten()));
        }
        else if (rider.getVoertuig() instanceof Scooter){
            vasteVergoeding = vasteVergoeding + (0.15 * AfstandTool.getAfstand(restaurant.getAdres().getCoordinaten(), klant.getAdres().getCoordinaten()));
        }
        /*
        if (ChronoUnit.MINUTES.between(gewensteLevertijd, levertijd) >= 15 && ChronoUnit.MINUTES.between(gewensteLevertijd, levertijd) <= 19){
            vasteVergoeding = vasteVergoeding * 0.94;
        }
        else if (ChronoUnit.MINUTES.between(gewensteLevertijd, levertijd) >= 10){
            vasteVergoeding = vasteVergoeding * 0.96;
        }
        else if (ChronoUnit.MINUTES.between(gewensteLevertijd, levertijd) >= 5){
            vasteVergoeding = vasteVergoeding * 0.98;
        }

         */
        return vasteVergoeding;
    }

    @Override
    public String getStatus() {
        DateTimeFormatter parser = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");
        //String output = "";
        StringBuilder sb = new StringBuilder();
        if (levertijd != null){
            sb.append("Bestelling geleverd om " + parser.format(levertijd));
            //output += "Bestelling geleverd om " + parser.format(levertijd)
        }
        else if (rider != null){
            sb.append("Verwachtte levertijd " + parser.format(gewensteLevertijd));
            //output +="Verwachte levertijd " + parser.format(gewensteLevertijd);
        }
        else {
            sb.append("Nog even geduld aub.");
            //output += "Nog even geduld aub. ";
        }
        //return output;
        return sb.toString();
    }

    @Override
    public void leveren(LocalDateTime levertijd) {
        double berekendeLeverkosten = berekenLeverkosten();
        if (levertijd == null){
            rider.plusBedrag(berekendeLeverkosten);
        }
        else {
            System.out.println("Deze bestelling is al geleverd");
        }
    }

    @Override
    public void setGewensteLevertijd(LocalDateTime gewensteLevertijd) {
        this.gewensteLevertijd = gewensteLevertijd;
    }
    public String toString(){
        DateTimeFormatter parser = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append(restaurant.getNaam() + "\n");
        stringBuilder.append("Gewenste levertijd: " + parser.format(gewensteLevertijd) + "\n");
        stringBuilder.append("Klant: " + klant.getVoornaam() + " " + klant.getAchternaam() + " ");
        if (klant.getMobiel() != null){
            stringBuilder.append(klant.getMobiel() + "\n");
        }
        else {
            stringBuilder.append("\n");
        }
        stringBuilder.append(klant.getAdres() + "\n");
        stringBuilder.append(getGerechten());
        return stringBuilder.toString();
    }
}
