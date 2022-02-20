# Een schoonmaakbedrijf wenst snel te kunnen uitrekenen hoeveel euro ze zullen aanrekenen voor het schoonmaken van een in te geven oppervlakte.
# Er wordt als volgt gerekend:
#
# 1 persoon kan op 1 uur tijd  160𝑚2  vloer poetsen
# 1 persoon kan maximaal 8 uur per dag werken
# 1 uur wordt doorgerekend aan 12,5 euro.
# Gevraagd: het aantal schoon te maken  𝑚2  wordt ingevoerd, waarna de kostprijs (berekend via een functie) en het aantal personen dat deze oppervlakte op 1 dag schoonmaakt (berekend via een functie) wordt afgedrukt.
#
# Per persoon wordt vermeld hoeveel uren hij zal moeten werken (vb 3 personen werken 8 uur, 1 persoon werkt 3,5 uur).
# Dit programma eindigt bij ingave van “0” als schoon te maken oppervlakte.
#
# Uitbreiding: elk begonnen uur wordt als een volledig uur aangerekend.


def kostprijs(oppervlakte):
    uren = oppervlakte / 160
    return uren * 12.5


def aantal_personen_schoongemaakt(oppervlakte):
    uren = oppervlakte / 160
    aantalpersonen_8u = uren // 8
    if aantalpersonen_8u > 8:
        if aantalpersonen_8u == 1:
            print("1 persoon werkt 8 uur")
        else:
            print(aantalpersonen_8u,"personen werken",uren,"uur")


def main():
    aantal_meter_gepoetst = int(input("geef heet aantal m² in dat gepoetst moet worden: "))
    while aantal_meter_gepoetst != 0:
        
        aantal_meter_gepoetst = int(input("geef heet aantal m² in dat gepoetst moet worden: "))
    aantal_personen_schoongemaakt(aantal_meter_gepoetst)

if __name__ == '__main__':
    main()
