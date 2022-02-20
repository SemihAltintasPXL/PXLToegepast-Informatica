package be.pxl.h7.oef3;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;

public class Result {

    public static final DateTimeFormatter parser = DateTimeFormatter.ofPattern("yyyy-MM-dd-HH:mm:ss");
    public static final DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");

    private String name;
    private LocalDateTime timestamp;
    private double result;

    public Result(String name, LocalDateTime timestamp, double result) {
        this.name = name;
        this.timestamp = timestamp;
        this.result = result;
    }

    public Result(String[] data) {
        this.timestamp = LocalDateTime.parse(data[0], parser);
        this.name = data[1];
        this.result = Double.parseDouble(data[2]);
    }

    public double getResult() {
        return result;
    }

    public String toFile() {
        return String.format("%s#%s#%.3f", parser.format(this.timestamp), this.name, this.result);
    }

    public String toString() {
        long diff = ChronoUnit.HOURS.between(this.timestamp,LocalDateTime.now());
        String unit = "uren";
        if(diff < 2) {
            diff = ChronoUnit.MINUTES.between(this.timestamp, LocalDateTime.now());
            unit = "minuten";
        }
        String diffString = String.format("%s %s", diff, unit);
        return String.format("%s %s (%s geleden)%n  >>> %.3f seconden", formatter.format(this.timestamp), this.name, diffString, this.result);
    }
}
