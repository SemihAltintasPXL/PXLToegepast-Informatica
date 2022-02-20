package be.pxl.h4.oef4;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class AdresTest {

    public static final String STRAATNAAM = "Nieuwstraat";
    public static final String HUISNUMMER = "156B";

    private Adres adres;

    @Before
    public void init() {
        adres = new Adres(STRAATNAAM, HUISNUMMER, GemeenteTest.POSTCODE, GemeenteTest.GEMEENTENAAM);
    }

    @Test
    public void testWaardenNaConstructor() {
        assertEquals(STRAATNAAM, adres.getStraat());
        assertEquals(HUISNUMMER, adres.getHuisnummer());
    }

    @Test
    public void testGemeenteNaConstructor() {
        assertEquals(GemeenteTest.GEMEENTENAAM, adres.getGemeente().getGemeenteNaam());
        assertEquals(GemeenteTest.POSTCODE, adres.getGemeente().getPostcode());
    }

    @Test
    public void testAdresToString() {
        assertEquals(STRAATNAAM + " " + HUISNUMMER + "\r\n" + GemeenteTest.POSTCODE + " " + GemeenteTest.GEMEENTENAAM, adres.toString());
    }
}
