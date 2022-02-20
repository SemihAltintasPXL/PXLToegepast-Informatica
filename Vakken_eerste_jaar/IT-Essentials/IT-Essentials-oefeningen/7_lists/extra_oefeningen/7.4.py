def bereken_loon(uurloon, aantal_uren_gewerkt):
    basisloon = 38 * uurloon
    if aantal_uren_gewerkt <= 38:
        return basisloon
    overuren = aantal_uren_gewerkt - 38
    if overuren > 15:
        basisloon += (overuren - 15) * 1.2 * uurloon
    overuren = 15
    if overuren > 10:
        basisloon += (overuren - 10) * 2 * uurloon
    overuren = 10
    if overuren > 0:
        basisloon += overuren * 1.5 * uurloon
    return basisloon


def bereken_terug_te_nemen_overuren(aantal_uren_gewerkt):
    if aantal_uren_gewerkt > 38 + 15:
        return aantal_uren_gewerkt - 38 - 15
    return 0


def bereken_categorie(aantal_uren_gewerkt):
    if aantal_uren_gewerkt < 38:
        return 0
    if aantal_uren_gewerkt == 38:
        return 1
    overuren = aantal_uren_gewerkt - 38
    if overuren <= 10:
        return 2
    if overuren <= 15:
        return 3
    else:
        return 4


def main():
    lijst = []
    categorieen = 5 * [0]  # teller voor elke categorie
    totaal_loon = 0
    totaal_terug_te_nemen_overuren = 0

    personeelsnummer = int(input("Geef de personeelsnummer in "))
    while personeelsnummer != 0:
        uurloon = int(input("Geef de uurloon in "))
        aantal_uren_gewerkt = int(input("Geef aantal uren gewerkt: "))
        categorieen[bereken_categorie(aantal_uren_gewerkt)] += 1  # teller voor elke categorie
        loon = bereken_loon(uurloon, aantal_uren_gewerkt)
        totaal_loon += loon
        overuren = bereken_terug_te_nemen_overuren(aantal_uren_gewerkt)
        totaal_terug_te_nemen_overuren += overuren
        lijst.append("{} {} {}".format(personeelsnummer, loon, overuren))
        personeelsnummer = int(input("Geef de personeelsnummer in "))

    for i in range(5):
        print("Categorie", i, ": ", categorieen[i])
    print("Totaal overuren: ", totaal_terug_te_nemen_overuren)
    print("Totaal loon: ", totaal_loon)
    for resultaat in lijst:
        print(resultaat)


if __name__ == '__main__':
    main()
