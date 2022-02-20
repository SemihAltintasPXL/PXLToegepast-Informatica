'''Maak een programma om het juiste sterrenbeeld van meerdere personen af te drukken.
Geef de naam, de voornaam en de geboortedatum van de persoon in. De geboortedatum geef je in in het formaat dd/mm/yyyy (bijv. 15/05/1999).
De invoer stopt wanneer voor de naam een “/” wordt ingegeven.
De sterrenbeelden zijn (in volgorde van de maanden van het jaar): waterman, vissen, ram, stier, tweelingen, kreeft, leeuw, maagd, weegschaal, schorpioen, boogschutter, steenbok.
We gaan er van uit dat telkens de 21ste van de maand een nieuw sterrenbeeld begint.
Dus wie jarig is tussen 21 januari en 20 februari is een waterman, wie jarig is tussen 21 februari en 20 maart heeft als sterrenbeeld vissen, …
Het bepalen van het juiste sterrenbeeld moet met een functie gebeuren.
Voor elke persoon moet de eerste letter van de voornaam gevolgd door een punt gevolgd door de achternaam (dit alles in hoofdletters) afgedrukt worden.
Het afdrukken van de naam van een persoon dient te gebeuren in een functie.

Bv.: Hans Andersen geboren op 3/2 geeft: H. ANDERSEN waterman'''


def bepaal_sterrenbeeld(dag, maand, sterrenbeeld):
    if dag > 21:
        return sterrenbeeld[maand]
    else:
        return sterrenbeeld[maand - 1]


def afdrukken_naam(voornaam, naam):
    vn = voornaam[0].upper
    an = naam.upper

    return str(vn) + "." + str(an)


def main():
    sterrenbeeld = ["", "waterman", "vissen", "ram", "stier", "tweelingen", "kreeft", "leeuw", "maagd", "weegschaal",
                    "schorpioen", "boogschutter", "steenbok", ]
    naam = input("Geef de naam in ")
    while naam != "/":
        voornaam = input("Geef de voornaam ")
        geboortedatum = input("Geef het geboortedatum in (dd/mm/yyyy) ")

        gesplitste_datum = geboortedatum.split("/")
        dag = int(gesplitste_datum[0])
        maand = int(gesplitste_datum[1])

        beeld = bepaal_sterrenbeeld(dag, maand, sterrenbeeld)
        afdruk_naam = afdrukken_naam(voornaam, naam)
        print("{} heeft als sterrenbeeld {}".format(afdruk_naam, beeld))

        naam = input("Geef de naam in ")


if __name__ == '__main__':
    main()
