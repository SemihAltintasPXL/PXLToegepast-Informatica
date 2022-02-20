'''Een telefoonmaatschappij rekent aan haar klanten tweemaandelijks een vast bedrag van 20 euro (aansluiting, huur, onderhoud).
Een telefoongesprek binnen België kost 12 eurocent (ongeacht de duur van het gesprek),
een telefoongesprek naar het buitenland kost 50 eurocent per begonnen minuut.
In deze tarieven is geen BTW inbegrepen.
Je geeft via het toetsenbord het aantal Belgische gesprekken op en het aantal minuten dat er naar het buitenland getelefoneerd werd in de afgelopen maand.
Het programma berekent hoeveel je moet betalen voor de afgelopen maand. Het BTW-percentage is 21%.'''

aantal_gesprekken = int(input("Geef het aantal Belgische gesprekken op "))
aantal_minuten = int(input("Geef het aantal minuten dat er naar het buitenland getelefoneerd werd op "))

prijs_belgie = aantal_gesprekken * 12
prijs_buitenland = aantal_minuten * 50
totaalprijs = 20 + (prijs_buitenland + prijs_belgie) * 1.12
print("Het totaal te betalen bedrag is", round(totaalprijs, 2), "euro.")
