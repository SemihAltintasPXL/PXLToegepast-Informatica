# zie extra opgave 3 van hoofdstuk 4


def bepaal_vervoersmiddel(code):
    if code == 1:
        vervoersmiddel = "met de bus"
    elif code == 2:
        vervoersmiddel = "te voet"
    elif code == 3:
        vervoersmiddel = "met de fiets"
    elif code == 4:
        vervoersmiddel = "met de trein"
    else:
        vervoersmiddel = "met de auto"
    return vervoersmiddel


def main():
    code = int(input("geef de code in "))
    minimum = 120  # initialisatie op een grote waarde!
    minimum_code = -1  # om te vermijden dat de interpreter foutmelding geeft bij afdrukken minimumcode
    teller = 0  # aantal personen te tellen
    som = 0  # som om de totale duur te berekenen
    teller_auto = 0  # om aantal personen te tellen die met de auto komt
    while code != 0:
        tijd = int(input("geef de tijd in"))
        teller += 1
        som += tijd
        if tijd < minimum:
            minimum = tijd
            minimum_code = code
        if code == 5:
            teller_auto += 1

        code = int(input("geef de code in "))
    gemiddelde = som / teller  # GEMIDDELDE ALTIJD NA DE LUS
    print("print de gemiddelde tijd is", gemiddelde)
    print("de minimale tijd is", minimum)
    print("dit was met vervoerscode", minimum_code)

    print("dit was", bepaal_vervoersmiddel(code))
    # extra percentage afgerond op 1 cijfer na de komme (= op 1 decimaal)

    percentage_auto = round(teller_auto / teller * 100, 1)
    print("het percentage dat met de auto komt:", percentage_auto)


if __name__ == '__main__':
    main()
