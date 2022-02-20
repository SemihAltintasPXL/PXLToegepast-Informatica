package be.pxl.h4.oef4;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class GemeenteTest {

    public static final String GEMEENTENAAM = "Hasselt";
    public static final int POSTCODE = 3500;

    private Gemeente gemeente;

    @Before
    public void init() {
        gemeente = new Gemeente(POSTCODE, GEMEENTENAAM);
    }

    @Test
    public void testGemeenteNaamNaConstructor() {
        assertEquals(GEMEENTENAAM, gemeente.getGemeenteNaam());
    }

    @Test
    public void testJuistePostcodeNaConstructor() {
        assertEquals(POSTCODE, gemeente.getPostcode());
    }

    @Test
    public void testPostcodeCorrectieTeKortBijConstructor() {
        Gemeente g1 = new Gemeente(35, "Hasselt");
        Gemeente g2 = new Gemeente(350, "Hasselt");
        assertEquals(POSTCODE, g1.getPostcode());
        assertEquals(POSTCODE, g2.getPostcode());
    }

    @Test
    public void testPostcodeCorrectieTeLangBijConstructor() {
        Gemeente g1 = new Gemeente(350000, "Hasselt");
        Gemeente g2 = new Gemeente(35000, "Hasselt");
        assertEquals(POSTCODE, g1.getPostcode());
        assertEquals(POSTCODE, g2.getPostcode());
    }

    @Test
    public void testSetPostCodeCorrecties() {
        gemeente.setPostcode(35);
        assertEquals(POSTCODE, gemeente.getPostcode());
        gemeente.setPostcode(3500000);
        assertEquals(POSTCODE, gemeente.getPostcode());
    }

    @Test
    public void testGemeenteToString() {
        assertEquals(POSTCODE + " " + GEMEENTENAAM, gemeente.toString());
    }
}

