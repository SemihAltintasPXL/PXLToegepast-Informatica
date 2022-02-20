'''Er worden 3 getallen ingelezen a, b en c. Als de som van a en b kleiner is dan 20, moet c bij deze som geteld worden en het resultaat afdrukt worden.
Als a en b samen groter dan of gelijk aan 20 zijn, dan moet de tekst te groot afgedrukt worden.'''

a = int(input("Geef een getal in "))
b = int(input("Geef een getal in "))
c = int(input("Geef een getal in "))
som = a + b

if (a + b) < 20:
    som += c
    print("De som is", som)
else:
    print("Te groot")
