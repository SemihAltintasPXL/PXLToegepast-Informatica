artikelnummer = int(input("Geef het artikelnummer: "))
som = 0
output = ""
while artikelnummer != 999:
    hoeveelheid = int(input("Geef de hoeveelheid in: "))
    eenheidsprijs = int(input("Geef de eenheidsprijs in: "))

    bedrag = hoeveelheid * eenheidsprijs

    output += "Artikelnummer: " + str(artikelnummer) + "\n"
    output += "Hoeveelheid: " + str(hoeveelheid) + "\n"
    output += "Eenheidsprijs: " + str(eenheidsprijs) + "\n"
    output += "Bedrag: " + str(bedrag) + "\n" + "\n"
    som += bedrag
    artikelnummer = int(input("Geef het artikelnummer: "))
output += "Totaal te betalen bedrag:" + str(som)
print(output)
