afstand = int(input("Geef de afstand in km: "))
klasse = int(input("Geef de nummer van de klasse in: "))

if afstand < 1000:
    prijs = 0.25 * afstand
elif afstand <= 2999:
    prijs = 20 * afstand
else:
    prijs = 12 * afstand

if klasse == 2:
    prijs *= 0.8
elif klasse == 2:
    prijs *= 1.3

print("Ticketprijs:", prijs * 100)