getal1 = int(input("Geef een getal in: "))
getal2 = int(input("Geef een getal in: "))

if getal1 < getal2:
    kleinste = getal1
    grootste = getal2
else:
    kleinste = getal2
    grootste = getal1

if kleinste == 0:
    print("Deling door 0!")
else:
    print("Het kleinste getal is", kleinste)
    print("Het kwadraat van het kleinste getal is", kleinste ** 2)
    print("Het grootste getal gedeeld door het kleinste getal is", grootste/kleinste)

