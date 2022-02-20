'''Het jaarlijks lidgeld bij een padel-vereniging bedraagt:

25 euro voor volwassenen
12.5 euro voor personen minder dan 18 jaar
6 euro voor personen minder dan 12 jaar.
Via het toetsenbord wordt de leeftijd van een lid ingevoerd. De leeftijd en het te betalen lidgeld moet afgedrukt worden.'''

leeftijd = int(input("Geef de leeftijd in "))
lidgeld = 25
if leeftijd < 12:
    lidgeld = 6
elif leeftijd < 18:
    lidgeld: 12.5

print("leeftijd : {} , te betalen lidgeld : {}".format(leeftijd, lidgeld))
