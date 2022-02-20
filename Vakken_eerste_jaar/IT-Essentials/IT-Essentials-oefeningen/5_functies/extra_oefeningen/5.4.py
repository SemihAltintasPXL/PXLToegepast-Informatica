def bereken_totale_kostprijs(type_ziekenwagen, afstand):
    if type_ziekenwagen == 'R':
        if afstand < 11:
            prijs = 25
        elif afstand < 21:
            prijs = 25 + (afstand - 11) * 2.25
        else:
            prijs = 25 + (afstand - 11) * 2.25 + (afstand - 21) * 1.75


    else:
        if afstand < 11:
            prijs = 20
        elif afstand < 21:
            prijs = 25 + (afstand - 11) * 1.75
        else:
            prijs = 25 + (afstand - 11) * 1.75 + (afstand * 21) * 1.15
    return prijs


def bereken_korting(type_ziekenwagen, afstand):
    if type_ziekenwagen == 'R':
        korting = 15
        if afstand > 11:
            korting = 15 + (afstand - 11) * 1.5



    else:
        korting = 10
        if afstand > 11:
            korting = 15 + (afstand - 11)

    return korting


def main():
    aantal_slachtoffers = 0
    aantal_leden_mutualiteit = 0
    naam_slachtoffer = input("Geef de naam van het slachtoffer in ")
    while naam_slachtoffer != "/":
        type_ziekenwagen = input("Reanimatiewagen of een gewone ziekenwagen? (R/Z) ")
        afstand = int(input("Geef de afstand in kilometers in "))
        lid = input("Lid mutualiteit? (J/N) ")
        aantal_slachtoffers += 1
        if lid == "J":
            aantal_leden_mutualiteit += 1

        totale_kostprijs = bereken_totale_kostprijs(type_ziekenwagen, afstand)
        korting = bereken_korting(type_ziekenwagen, afstand)
        netto_bedrag = totale_kostprijs - korting

        print("Naam slachtoffer: {} , totale kostprijs: {} , netto te betalen bedrag: {}".format(naam_slachtoffer,
                                                                                                 totale_kostprijs,
                                                                                                 netto_bedrag))

        naam_slachtoffer = input("Geef de naam van het slachtoffer in ")
    print("Aantal vervoerde slachtoffers =", aantal_slachtoffers)
    print("Percentage dat lid is van de mutualiteit =",
          round((aantal_leden_mutualiteit / aantal_slachtoffers) * 100, 2))


if __name__ == '__main__':
    main()
