package be.pxl.h4.oef4;

import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;

import static org.junit.Assert.assertEquals;

public class HuwelijkTest {

    private static final Persoon PARTNER1 = new Persoon("Vervoort", "Jos", LocalDate.of(1974,2,15), new Adres("Nieuwstraat", "156B", 3500, "Hasselt"));
    private static final Persoon PARTNER2 = new Persoon("Bex", "Jeanne", LocalDate.of(1972, 12, 3), new Adres("Vlierstraat", "14", 3600, "Genk"));
    private static final LocalDate DATUM = LocalDate.of(2001, 8, 4);
    private static final Adres NIEUW_ADRES = new Adres("Dorpsstraat", "53", 3590, "Diepenbeek");

    private Huwelijk huwelijk;

    @Before
    public void init() {
        huwelijk = new Huwelijk(PARTNER1, PARTNER2, DATUM.getDayOfMonth(), DATUM.getMonthValue(), DATUM.getYear());
    }

    @Test
    public void testPartnersNaConstructor() {
        assertEquals(PARTNER1.getNaam(), huwelijk.getPartner1().getNaam());
        assertEquals(PARTNER1.getVoornaam(), huwelijk.getPartner1().getVoornaam());

        assertEquals(PARTNER2.getNaam(), huwelijk.getPartner2().getNaam());
        assertEquals(PARTNER2.getVoornaam(), huwelijk.getPartner2().getVoornaam());
    }

    @Test
    public void testDatumWaardeNaConstructor() {
        assertEquals(DATUM, huwelijk.getHuwelijksdatum());
    }

    @Test
    public void testAdresAanpassingNaConstructor() {
        assertEquals(huwelijk.getPartner2().getAdres(), huwelijk.getPartner1().getAdres());
    }

    @Test
    public void testAdresWijzigingPartner1() {
        huwelijk.adresWijziging(NIEUW_ADRES.getStraat(), NIEUW_ADRES.getHuisnummer(), NIEUW_ADRES.getGemeente().getPostcode(), NIEUW_ADRES.getGemeente().getGemeenteNaam());
        assertEquals(NIEUW_ADRES.getStraat(), huwelijk.getPartner1().getAdres().getStraat());
        assertEquals(NIEUW_ADRES.getHuisnummer(), huwelijk.getPartner1().getAdres().getHuisnummer());
        assertEquals(NIEUW_ADRES.getGemeente().getPostcode(), huwelijk.getPartner1().getAdres().getGemeente().getPostcode());
        assertEquals(NIEUW_ADRES.getGemeente().getGemeenteNaam(), huwelijk.getPartner1().getAdres().getGemeente().getGemeenteNaam());
    }

    @Test
    public void testAdresWijzigingPartner2() {
        huwelijk.adresWijziging(NIEUW_ADRES.getStraat(), NIEUW_ADRES.getHuisnummer(), NIEUW_ADRES.getGemeente().getPostcode(), NIEUW_ADRES.getGemeente().getGemeenteNaam());
        assertEquals(NIEUW_ADRES.getStraat(), huwelijk.getPartner2().getAdres().getStraat());
        assertEquals(NIEUW_ADRES.getHuisnummer(), huwelijk.getPartner2().getAdres().getHuisnummer());
        assertEquals(NIEUW_ADRES.getGemeente().getPostcode(), huwelijk.getPartner2().getAdres().getGemeente().getPostcode());
        assertEquals(NIEUW_ADRES.getGemeente().getGemeenteNaam(), huwelijk.getPartner2().getAdres().getGemeente().getGemeenteNaam());
    }
}