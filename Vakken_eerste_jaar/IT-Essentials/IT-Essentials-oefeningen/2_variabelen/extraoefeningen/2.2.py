'''De diameter van een fietswiel wordt meestal opgegeven in inches (1 inch=0,0254 m).
Bepaal de omwenteling van een wiel in meters uitgedrukt, bij een opgegeven diameter in inches, en druk het bekomen resultaat af. Voorbeeld:

diameter van een wiel: 16 inches
afgelegde weg van een omwenteling:  16×3,14
afgelegde weg uitgedrukt in m:  16×3,14×0,0254'''

diameter_inch = int(input("Geef een diamter op in inches "))
diameter_meter = diameter_inch * 0.0254
omwenteling_meter = diameter_meter * 3.14

print("Omwenteling van een wiel met een diameter van {} inch is {} meter.".format(diameter_inch, omwenteling_meter))
