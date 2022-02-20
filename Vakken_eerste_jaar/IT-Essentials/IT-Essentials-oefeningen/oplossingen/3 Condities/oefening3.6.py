jaar = int(input("Geef het jaar van de film in: "))
rating = int(input("Geef de rating van de film in: "))

prijs = 5
if jaar > 2019:
    prijs += 1

if rating == 1 or rating == 2:
    prijs += 1
elif rating == 4 or rating == 5:
    prijs +=2

if prijs < 7:
    prijs = 7

print("De prijs van de film bedraagt", prijs, "euro.")