'''Een onderneming wenst aan haar personeelsleden een premie uit te betalen die in verhouding staat tot het aantal dienstjaren.
 Bereken de individuele premie en de totale premie.
 Per personeelslid dient via het toetsenbord het volgende ingegeven te worden:
 de familienaam (invoer van "/" of "*" betekent het einde van het programma),
 voornaam en het aantal dienstjaren. Zorg voor een invoercontrole op het aantal dienstjaren,
 dit moet een getal zijn tussen 0 en 40 jaar.
 De premie wordt als volgt berekend: het aantal dienstjaren * 25 euro.
 Als het aantal dienstjaren minder zijn dan 5, krijgt de persoon 0 euro als premie.
 Druk per persoon de familienaam, de voornaam, het aantal jaren dienst en de premie af.
 Druk aan het einde van het programma de totaal te betalen premie en de hoogste premie af. '''
hoogste_premie = 0
premie = 1
totale_premie = 0
output = ""  # overbodig
familienaam = str(input("Geef de familienaam in: "))
while familienaam != "/" and familienaam != "*":
    voornaam = str(input("Geef de voornaam in: "))
    aantal_dienstjaren = int(input("Geef het aantal dienstjaren in: "))
    while aantal_dienstjaren < 0 or aantal_dienstjaren > 40:
        aantal_dienstjaren = int(input("Foutief getal, voer opnieuw in. "))

    if aantal_dienstjaren < 5:
        premie = 0

    else:
        premie = aantal_dienstjaren * 25
        totale_premie += premie

        if premie > hoogste_premie:
            hoogste_premie = premie

    output += "Familienaam: " + str(
        familienaam) + "\n"  # output += is hier overbodig, je kan ook gewoon elk onderdeel printen
    output += "Voornaam: " + str(voornaam) + "\n"
    output += "Aantal jaren in dienst: " + str(aantal_dienstjaren) + "\n"
    output += "Premie: " + str(premie) + str(" euro") + "\n" + "\n"

    familienaam = str(input("Geef de familienaam in: "))

print(output)
print("De totaal te betalen premie bedraagt: " + str(totale_premie) + str(
    " euro. Met als hoogste premie: " + str(hoogste_premie) + str(" euro")))
