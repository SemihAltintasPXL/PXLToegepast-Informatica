'''Hoeveel omwentelingen zal een wiel moeten maken om een opgegeven aantal m af te leggen.
De diameter van het fietswiel wordt in inches opgegeven (zie vorige opgave).
Volgende gegevens worden ingelezen: diameter fietswiel en de af te leggen afstand.'''

diameter_inch = int(input("Geef een diameter van de fietswiel op in inches "))
afstand = int(input("Geef de afstand in meter in "))

diameter_meter = diameter_inch * 0.0254
omwenteling_meter = diameter_meter * 3.14
aantal_omwentelingen = afstand / omwenteling_meter

print("De wiel moet {} omwentelingen maken om {} m af te leggen.".format(round(aantal_omwentelingen), afstand))
