# extra oefening; ga na of een ingegeven getal <10, tussen 10 en 100 ligt (grenzen inbegrepen), groter dan 100

getal = int(input("geef een getal in "))

if getal < 10:
    print("kleiner dan 10")
elif getal <= 100:  # niet oke elif getal>= 10 and getal <=100:   anders ben je aan het testen wat we al weten
    print("getal ligt tussen 10 en 100 (grenzen inbegrepen")
else:  # niet oke elif getal > 100:
    print("getal groter dan 100")
