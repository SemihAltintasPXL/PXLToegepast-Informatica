'''Schrijf een programma dat een variabele gewicht
heeft. Als gewicht groter is dan 20 (kilo), print je: “Er
moet een toeslag van €25 betaald worden voor
bagage die te zwaar is.” Als gewicht kleiner is dan 20,
print je: “Goede reis!”. Als gewicht precies 20 is, print
je: “Poeh! Dat gewicht is precies goed!”.
Wijzig de waarde van gewicht een paar keer om de
code te testen'''

gewicht = int(input("geef het gewicht van je bagage in"))
if gewicht < 20:
    print("Goede reis!")
elif gewicht == 20:
    print("Poeh! Dat gewicht is precies goed!")
else:  # niet oke: elif gewicht >20:  want dit is vanzelfsprekend, het is zinloos om het nog te berekenen
    print("Er moet een toeslag van 25 euro betaald worden voor baggage die te zwaar is")
