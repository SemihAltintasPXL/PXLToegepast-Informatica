package be.pxl.h5.oefening2;

import org.junit.Before;
import org.junit.Test;
import be.pxl.h5.oefening2.Voetballer;
import be.pxl.h5.oefening1.Persoon;

import static org.junit.Assert.*;

public class VoetballerTest {
    @Test
    public void testConstructorMet1Parameter() {
        Voetballer voetballer = new Voetballer("Janssen", "Kurt");
        assertTrue("Kurt".equalsIgnoreCase(voetballer.getVoornaam()));
        assertTrue("Janssen".equalsIgnoreCase(voetballer.getNaam()));
        assertTrue("voetbal".equalsIgnoreCase(voetballer.getOmschrijving()));
        assertEquals("onbepaald", voetballer.getClub());
        assertEquals("onbepaald", voetballer.getOpstelling());
    }

    @Test
    public void testConstructorMet4Parameters() {
        Voetballer voetballer = new Voetballer("Janssen", "Kurt", "PSV", "verdediger");
        assertTrue("Kurt".equalsIgnoreCase(voetballer.getVoornaam()));
        assertTrue("Janssen".equalsIgnoreCase(voetballer.getNaam()));
        assertTrue("voetbal".equalsIgnoreCase(voetballer.getOmschrijving()));
        assertTrue("PSV".equalsIgnoreCase(voetballer.getClub()));
        assertTrue("verdediger".equalsIgnoreCase(voetballer.getOpstelling()));
    }

    @Test
    public void testSetOpstellingJuist() {
        Voetballer voetballer = new Voetballer("Janssen", "Kurt");
        voetballer.setOpstelling("verdediger");
        assertTrue("verdediger".equalsIgnoreCase(voetballer.getOpstelling()));
    }

    @Test
    public void testSetOpstellingFout() {
        Voetballer voetballer = new Voetballer("Janssen", "Kurt");
        voetballer.setOpstelling("duivenmelker");
        assertTrue("onbepaald".equalsIgnoreCase(voetballer.getOpstelling()));
    }
}
