def aantal_deelnemers(lijst):
    return len(lijst[0])  # lengte van de eerste rij is gelijk aan het aantal deelnemers


def aantal_testen(lijst):
    return len(lijst)


def hoogste_hartslag(lijst):
    grootste = 0
    for rij in lijst:
        for getal in rij:
            if getal > grootste:
                grootste = getal
    return grootste


def laagste_hartslag(lijst):  # door gebruik te maken van ingebouwde functies
    '''minimum = min(lijst[0])
       for i in range(1,len(lijst)):
           min_rij = min(lijst[i])
           if minimum < min_rij:
               minimum = min_rij
       return minimum
       DEZE OPLOSSING IS GOED, MAAR NU EEN OPLOSSING ZONDER GEBRUIK TE MAKEN VAN IF:   '''
    minimum_lijst = []
    for i in range(len(lijst)):
        minimum_lijst.append(min(lijst[i]))
    return min(minimum_lijst)


def gemiddelde_hartslag(lijst):  # gemiddelde per test
    gemiddelde_lijst = []
    for rij in lijst:
        gemiddelde_test = sum(rij) / rij
        gemiddelde_lijst.append(gemiddelde_test)
    return gemiddelde_lijst


def verschil_hartslag(lijst):  # per deelnemer verschil tussen hoogste en laagste
    verschil_lijst = []
    for j in range(len(lijst[0])):  # of range(aantal_deelnemers(lijst)
        hoogste = lijst[0][j]  # initialiseren op de eerste element in de kolom
        laagste = lijst[0][j]
        for i in range(1, len(lijst)):
            if lijst[i][j] > hoogste:
                hoogste = lijst[i][j]
            elif lijst[i][j] < laagste:
                laagste = lijst[i][j]

        verschil = hoogste - laagste
        verschil_lijst.append(verschil)
    return verschil_lijst


def main():
    lijst = [[71, 75, 71, 73, 72, 76], [91, 90, 64, 93, 88, 91], [130, 135, 139, 142, 129, 138],
             [120, 118, 110, 105, 121, 119]]

    print("Het aantal deelnemers", aantal_deelnemers(lijst))
    print("Het aantal testen", aantal_testen(lijst))
    print("De hoogste hartslag", hoogste_hartslag(lijst))
    print("De laagste hartslag", laagste_hartslag(lijst))
    print("De gemiddelde hartslag per test", gemiddelde_hartslag(lijst))
    print("verschil per deelnemer tussen hoogste en laagste", verschil_hartslag(lijst))


if __name__ == '__main__':
    main()
