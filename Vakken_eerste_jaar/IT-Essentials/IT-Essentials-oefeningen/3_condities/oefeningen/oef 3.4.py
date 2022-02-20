'''Geef 2 getallen in via het toetsenbord. Maak een afdruk als volgt:

Het kleinste getal is ..
Het kwadraat van het kleinste getal is..
Het grootste getal gedeeld door het kleinste getal is .. (Let op voor deling door 0!)
Vermijd identieke lijnen code!'''

a = int(input("Geef een getal in "))
b = int(input("Geef nog een getal in "))

if a < b:
    print("Het kleinste getal is", a)
    print("Het kwadraat van het kleinste getal is", a ** 2)
    if a != 0:
        print("Het grootste getal gedeeld door het kleinste getal is", b / a)

else:
    print("Het kleinste getal is", b)
    print("Het kwadraat van het kleinste getal is", b ** 2)
    if b != 0:
        print("Het grootste getal gedeeld door het kleinste getal is", a / b)
