bs = int(input("geef bs in (1= ongehuwd, 2 = gehuwd, 3= weduwe(naar) "))
leeftijd = int(input("geef de leeftijd in"))
# iedereen jonger dan 30 + alle ongehuwden 25 rest 15

if leeftijd < 30 or bs == 1:
    lidgeld = 25
else:
    lidgeld = 15
print("lidgeld = ", lidgeld)
