import math


def bereken_breedte_plank(code):
    code = code.upper()
    if code[-1] == "S":
        breedte_plank = 12.8
    elif code[-1] == "M":
        breedte_plank = 20.5
    elif code[-1] == "L":
        breedte_plank = 26
    else:
        breedte_plank = 33
    return breedte_plank


def bereken_aantal_planken(breedte_plank, lengte, breedte):
    aantal_rijen = math.ceil(breedte / breedte_plank)
    aantal_planken = math.ceil((aantal_rijen * lengte) / 125)
    return aantal_planken


def bereken_oppervlakte_plank(aantal_planken, breedte_plank):
    oppervlakte = breedte_plank * aantal_planken * 125 / 10000
    return oppervlakte


def bereken_prijs_kamer(code, oppervlakte):
    tel = code.count("x")
    if tel == 1:
        prijs = 31.99
    else:
        prijs = 20.49

    return prijs * oppervlakte


def main():
    output = []
    smal = False
    aantal_kamers = int(input("Geef het aantal kamers in "))
    totaal_planken = 0
    totaal_tebetalen = 0
    for i in range(1, aantal_kamers + 1):
        print("Geef de gegevens van kamer", i)
        lengte = float(input("Geef de lengte in cm "))
        breedte = float(input("Geef de breedte in cm "))
        code = input("Geef type plank in ")
        breedte_plank = bereken_breedte_plank(code)
        if breedte_plank < 21:
            smal = True
        aantal_planken = bereken_aantal_planken(breedte_plank, lengte, breedte)
        oppervlakte = bereken_oppervlakte_plank(aantal_planken, breedte_plank)
        te_betalen = bereken_prijs_kamer(code, oppervlakte)
        totaal_planken += aantal_planken
        totaal_tebetalen += te_betalen
        output.append(
            "Het aantal planken voor kamer {} van het type {} is {} prijs €{:.2f}".format(i, code, aantal_planken,
                                                                                          te_betalen))
    for tekst in output:
        print(tekst)
    if totaal_planken >= 100:
        korting = 0.075
    elif totaal_planken >= 50 and smal:
        korting = 0.075
    else:
        korting = 0
    totaal_korting = totaal_tebetalen * korting
    totaal_tebetalen -= totaal_korting
    totaal_tebetalen = math.ceil(totaal_tebetalen / 5) * 5
    print("Het totaal aantal planken is {}".format(totaal_planken))
    print("De korting bedraagt €{:.2f}".format(totaal_korting))
    print("Te betalen: €{}".format(totaal_tebetalen))


if __name__ == '__main__':
    main()
