import math


def bereken_oppervlakte(hoogte, breedte):
    oppervlakte = hoogte * breedte
    return oppervlakte


def bereken_gewicht(oppervlakte, gewicht_per_m2):
    gewicht = oppervlakte * gewicht_per_m2
    return gewicht


def bepaal_motortype(gewicht):
    if gewicht < 150:
        return 'A101'
    elif gewicht <= 300:
        return 'A105'
    else:
        return 'X300'


def bereken_prijs_motor(motortype):
    if motortype == 'A101':
        return 120
    elif motortype == 'A105':
        return 220.5
    else:
        return 250.5


def bereken_prijs_poort(oppervlakte, prijs_motor, speciale_kleur):
    if speciale_kleur == "Nee":
        prijs = oppervlakte * 113.5 + prijs_motor
    else:
        prijs = ((oppervlakte * 113.5) * 1.1) + prijs_motor
    return prijs


def genereer_offertenummer(naam, totaalprijs):
    naam = naam.upper()
    totaalprijs = int(totaalprijs)
    totaalprijs = str(totaalprijs)
    totaalprijs = (totaalprijs[::-1])
    print("2021_{}_{}".format(naam, totaalprijs))


def main():
    naam = input("Naam van de verkoper: ")
    hoogte_poort = float(input("Hoogte van de poort in meter: "))
    while hoogte_poort < 2 or hoogte_poort > 6.5:
        hoogte_poort = float(
            input("Foute ingave, de hoogte moet liggen tussen 2m en 6.5m: "))  # INVOERCONTROLE MOET IN EEN FUNCTIE
    breedte_poort = float(input("Breedte van de poort in meter: "))
    while breedte_poort < 2 or breedte_poort > 8:
        breedte_poort = float(input("Foute ingave, de breedte moet liggen tussen 2m en 8m: "))
    speciale_kleur = input("Wenst u een speciale kleur? (Ja/Nee) ")

    oppervlakte_poort = bereken_oppervlakte(hoogte_poort, breedte_poort)
    gewicht_poort = bereken_gewicht(oppervlakte_poort, 11)
    prijs_motor = bereken_prijs_motor(gewicht_poort)
    prijs_poort = bereken_prijs_poort(oppervlakte_poort, prijs_motor, speciale_kleur)
    totaalprijs = prijs_motor + prijs_poort
    genereer_offertenummer(naam, totaalprijs)


if __name__ == '__main__':
    main()
