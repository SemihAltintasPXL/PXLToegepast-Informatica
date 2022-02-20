bs = int(input("geef bs in (1= ongehuwd, 2 = gehuwd, 3= weduwe(naar) "))
leeftijd = int(input("geef de leeftijd in"))
# ongehuwd: 25 ,gehuwd jonger dan 30 : 20, rest 15

if bs == 1:
    lidgeld = 25
elif bs == 2 and leeftijd < 30:
    lidgeld = 20
else:
    lidgeld = 15

print("lidgeld = ", lidgeld)
