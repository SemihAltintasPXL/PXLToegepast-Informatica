'''Een bankbediende wenst snel te kunnen uitrekenen hoeveel de waarde van een bepaald bedrag in euro is in US dollar.
Aan het begin van het programma geeft hij de waarde van de euro in t.o.v. de US dollar, vb. 1 euro = 1,28 US dollar (1,28 wordt ingevoerd).
Vervolgens worden bedragen in euro ingevoerd, waarna de waarde in US dollar getoond wordt. De omzetting gebeurt via een functie.
Het programma eindigt als voor het bedrag in euro 0 wordt ingevoerd.'''


def omzetting(bedrag, wisselkoers):
    bedrag_dollar = bedrag * wisselkoers
    return bedrag_dollar


def main():
    wisselkoers = float(input("Geef de wisselkoers in "))
    bedrag = float(input("Geef een bedrag in euro in: "))

    while bedrag != 0:
        print(bedrag, "euro =", omzetting(bedrag, wisselkoers), "dollar")
        bedrag = float(input("Geef een bedrag in euro in: "))


if __name__ == "__main__":
    main()
