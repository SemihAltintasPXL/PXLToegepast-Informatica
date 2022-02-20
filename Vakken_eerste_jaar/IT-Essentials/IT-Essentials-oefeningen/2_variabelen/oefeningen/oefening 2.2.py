#De toegangsprijs voor een dierentuin bedraagt 11 euro voor volwassenen en 6 euro voor kinderen onder de 12 jaar. Maak een programma dat het aantal volwassenen en kinderen inleest via toetsenbord en dat de totale prijs berekent en afdrukt.

aantal_volwassenen = int(input("Geef aantal volwassenen in "))
aantal_kinderen = int(input("Geef aantal kinderen in "))

print("De toegangsprijs bedraagt",(aantal_volwassenen * 11)+(aantal_kinderen * 6))