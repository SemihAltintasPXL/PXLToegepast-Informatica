'''De prijs van een vliegtuigticket wordt bepaald door een aantal factoren, nl.:

de lengte van de vlucht of de afstand in km
< 1000 km: korte afstandsvlucht: 25 eurocent/km
1000-2999 km: middellange afstandsvlucht: 20 eurocent/km
> 2999 km: lange afstandsvlucht: 12 eurocent/km
de soort vlucht of klasse:
toeristenklasse
charter -20%
zakenreis +30%

Schrijf een programma dat de prijs van een vliegtuigticket berekent.
De afstand in km en de klasse (1 = toeristenklasse, 2 = charter en 3 = zakenreis) dienen ingegeven te worden.
Druk de uiteindelijke ticketprijs af. Deze prijs moet uitgedrukt zijn in euro’s.'''

afstand = float(input("Geef de afstand in km in: "))
klasse = int(input("Geef de klasse in :(1 = toeristenklasse, 2 = charter en 3 = zakenreis "))

if afstand < 1000:
    prijs = 0.25 * afstand
elif afstand < 3000:
    prijs = 0.20 * afstand
else:
    prijs = 0.12 * afstand

if klasse == 2:
    prijs = prijs - (prijs / 100 * 20)
elif klasse == 3:
    prijs = prijs + (prijs / 100 * 30)

print("De ticketprijs bedraagt", prijs, "euro.")
