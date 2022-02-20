''' Maak een programma om de aankoopprijs van een DVD te berekenen.
Geef via het toetsenbord in van welk jaar de film is en welke rating (getal 1-5).
De basisprijs is steeds 5 euro. Voor een film die minder dan 2 jaar oud is, wordt een euro extra betaald.
Voor films met rating 4 of 5 betaal je 2 euro meer.
 Druk de prijs van de film af.

 Uitbreiding :

Voor films met rating 3 of 2 betaal je 1 euro meer
Let erop dat een film nooit meer kost dan 7 euro'''

jaartal = int(input("Geef het jaartal in van de film "))
rating = int(input("Geef in welke rating deze film heeft (1 - 5) "))

prijs = 5

if jaartal > 2019:
    prijs = prijs + 1

if rating == 4 or rating == 5:
    prijs = prijs + 2
elif rating == 2 or rating == 3:
    prijs = prijs + 1
if prijs > 7:
    prijs = 7

print("De prijs van de film bedraagt", prijs, "euro.")
