'''Schrijf een programma dat toelaat de leeftijd en het aansluitingsjaar
 van een lid van een tennisclub in te voeren en dat op basis hiervan zijn bijdrage berekent en afdrukt.
 Volgende regels worden hierbij gerespecteerd:

Basisbedrag: 100 euro
Reductie: 14.5 euro indien het lid nog geen 21 is of ouder is dan 60
Reductie: 2.5 euro per aangesloten jaar
Minimum te betalen bedrag is 62.5 euro.

Gebruik een constante met de waarde van het huidige jaar.'''

HUIDIG_JAAR = 2021
leeftijd = int(input("Geef de leeftijd in: "))
aansluitingsjaar = int(input("Geef het aansluitingsjaar: "))

bedrag = 100
if leeftijd < 21 or leeftijd > 60:
    bedrag -= 14.5

bedrag = bedrag - (HUIDIG_JAAR - aansluitingsjaar) * 2.5
if bedrag < 62.5:
    bedrag = 62.5

print("De prijs bedraagt", bedrag, "euro.")
