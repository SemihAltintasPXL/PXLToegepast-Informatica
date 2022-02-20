package be.pxl.examen;

import java.time.LocalDateTime;

public interface Leverbaar {
    double berekenLeverkosten();
    String getStatus();
    void leveren(LocalDateTime levertijd);
    void setGewensteLevertijd(LocalDateTime gewensteLevertijd);
}
