# geef getallen in totdat het ingegeven getal deelbaar is door 5
# als een ingegeven getal deelbaar is door 2 druk je af: getal ... is deelbaar door 2

getal = int(input("geef een getal in "))
while getal % 5 != 0:
    if getal % 2 == 0:
        print("getal", getal, "is deelbaar door 2")
    getal = int(input("geef een getal "))
print("Einde")
