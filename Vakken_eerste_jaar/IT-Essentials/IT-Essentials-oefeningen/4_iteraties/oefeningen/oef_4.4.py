'''Schrijf een programma om het gewicht van een persoon te berekenen op de Maan, Jupiter en Mars.
Volgende gegevens worden via het toetsenbord ingevoerd:
percentage van het gewicht t.o.v. aarde: Maan 16,5%; Jupiter 253,7 % en Mars 37,8%.

Aarde: 50
Maan: 8.25
Jupiter: 126.85
Mars: 18.9

Aarde: 55
Maan: 9.075000000000001
Jupiter: 139.535
Mars: 20.79

Aarde: 60
Maan: 9.9
Jupiter: 152.22
Mars: 22.68

...

Aarde: 120
Maan: 19.8
Jupiter: 304.44
Mars: 45.36'''

gewicht_maan = float(input("Percentage maan t.o.v. aarde: ")) / 100
gewicht_jupiter = float(input("Percentage jupiter t.o.v. aarde: ")) / 100
gewicht_mars = float(input("Percentage mars t.o.v. aarde: ")) / 100

for i in range(50, 125, 5):
    print("Aarde:", i)
    print("Maan:", i * gewicht_maan)
    print("Jupiter:", i * gewicht_jupiter)
    print("Mars:", i * gewicht_mars)
    print()
