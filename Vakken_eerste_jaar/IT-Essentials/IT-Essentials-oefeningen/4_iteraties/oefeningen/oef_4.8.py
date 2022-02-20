'''Er wordt door renners een tijdrit gereden over een afstand van 36 km.
Van iedere renner wordt inschrijvingsnummer en zijn tijd in seconden gegeven. Deze gegevens dienen ingegeven te worden.
De invoer stopt wanneer er voor het inschrijvingsnummer een negatief getal wordt ingegeven.
We veronderstellen dat alle renners er een verschillende tijd over doen. Gevraagd:

Welke renner is het snelst?
Het percentage van de renners dat er langer dan 1 uur over doet? Zorg voor volgende afdruk:
Snelste renner is de renner met inschrijvingsnummer: .........
Het percentage van de renners dat er langer dan 1 uur over doet :………
Extra: Geef van de snelste renner ook zijn tijd in uren, minuten en seconden. En druk dit ook af.'''

AFSTAND = 36000  # in meter
teller = 0
teller_meer = 0
snelste = 1000000000  # moet groter zijn dan 2uur
snelste_nummer = 0
inschrijvingsnummer = int(input("geef inscrhijvingsnummer "))
while inschrijvingsnummer >= 0:
    teller += 1
    tijd_sec = int(input("geef de tijd in seconden "))
    if tijd_sec < snelste:
        snelste = tijd_sec
        snelste_nummer = inschrijvingsnummer
    if tijd_sec > 60 * 60:
        teller_meer += 1

    inschrijvingsnummer = int(input("geef inscrhijvingsnummer "))

print("Het percentage van de renners dat er langer dan 1 uur over doet:", (teller_meer / teller) * 100, "%")
print("Snelste renner is de renner met inschrijvingsnummer", snelste_nummer)
