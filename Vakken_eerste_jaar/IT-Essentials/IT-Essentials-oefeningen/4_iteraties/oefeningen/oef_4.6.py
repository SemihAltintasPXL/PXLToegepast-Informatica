'''Geef via het toetsenbord artikelnummer, hoeveelheid en eenheidsprijs in.
De invoer eindigt met artikelnummer = 999. Gevraagd een afdruk van:

de gegevens per artikel (artikelnummer, hoeveelheid, eenheidsprijs, bedrag)
het totaal te betalen bedrag van de aankoop.'''

artikelnummer = int(input("Geef het artikelnummer in: "))
som = 0
output = ""  # dit is een string dus geen 0 zetten maar ""
while artikelnummer != 999:
    hoeveelheid = int(input("Geef de hoeveelheid in "))
    eenheidsprijs = int(input("Geef de eenheidsprijs in "))

    bedrag = hoeveelheid * eenheidsprijs

    output += "Artikelnummer: " + str(artikelnummer) + "\t"
    output += "Hoeveelheid: " + str(hoeveelheid) + "\t"
    output += "Eenheidsprijs: " + str(eenheidsprijs) + "\t"
    output += "Bedrag: " + str(bedrag) + "\n"

    som += bedrag

    artikelnummer = int(input("Geef het artikelnummer in: "))

output += "Totaal te betalen bedrag:" + str(som)
print(output)
