# Schrijf een programma dat de kosten berekent voor het plaatsen van kamerbreed tapijt.
# De gebruiker van het programma geeft de lengte en breedte van het tapijt in (uitgedrukt in meter), de prijs per m2 en de plaatsingskosten per m2 in.
# Als resultaat moet de kostprijs van het tapijt, de plaatsingskosten en de totale kosten afgedrukt worden.


lengte = float(input("Geef de lengte van het tapijt op "))
breedte = float(input("Geef de breedte van het tapijt op "))
prijs_m2 = float(input("Geef de prijs per viekante meter op "))
plaatsingskosten_m2 = float(input("Geef de plaatsinskosten per vierkante meter op "))

prijs = (lengte * breedte * prijs_m2)
plaatsingskosten = (lengte * breedte * plaatsingskosten_m2)

print("De kostprijs van het tapijt bedraagt ", prijs, 'euro')
print("De plaatsingskosten bedraagt", plaatsingskosten, 'euro')
print("De totale kost bedraagt", (prijs + plaatsingskosten), 'euro')
