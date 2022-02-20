'''Schrijf een programma om de prijs te berekenen van het geleverde water. De prijs wordt berekend in functie van het verbruik.
Er is steeds een vast recht van 25 euro te betalen. Voor dit bedrag krijgt de abonnee  30𝑚3  geleverd. Wie meer dan  30𝑚3  verbruikt moet dit meerverbruik betalen.
De prijs ervan is afhankelijk van de verbruikte hoeveelheid.

Als het totale waterverbruik groter is dan 30 maar kleiner dan of gelijk aan  200𝑚3  betaalt de abonnee 1 euro per  𝑚3  voor het meerverbruik.
Als het totale waterverbruik groter is dan 200 maar kleiner dan of gelijk aan  5000𝑚3  betaalt de abonnee 1.15 euro per  𝑚3  voor het meerverbruik.
Als het totale waterverbruik groter is dan  5000𝑚3  betaalt de abonnee 1.175 euro per  𝑚3  voor het meerverbruik.'''

verbruik = int(input("Geef het verbruik in "))

if verbruik <= 30:
    prijs = 25
elif verbruik <= 200:
    prijs = 25 + (verbruik - 30)
elif verbruik <= 5000:
    prijs = 25 + (verbruik - 30) * 1.15
else:
    prijs = 25 + (verbruik - 30) * 1.75

print("Voor {} m3 water bedraagt de prijs {} euro".format(verbruik, prijs))
