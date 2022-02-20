
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
            print(aantalpersonen_8u)

def main():
    aantal_meter_gepoetst = int(input("geef heet aantal m² in dat gepoetst moet worden: "))



if __name__ == '__main__':
    main()
