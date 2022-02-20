bs = int(input("geef bs in (1= ongehuwd, 2 = gehuwd, 3= weduwe(naar) "))
leeftijd = int(input("geef de leeftijd in"))
# ongehuwd jonger dan 30: 25 euro , rest 15 euro

if bs == 1 and leeftijd < 30:
    lidgeld = 25
else:
    lidgeld = 15
print("lidgeld= ", lidgeld)
