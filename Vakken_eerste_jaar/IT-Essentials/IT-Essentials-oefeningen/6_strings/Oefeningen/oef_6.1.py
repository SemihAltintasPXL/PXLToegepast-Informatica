'''Bepaal in een tekst de positie van de eerste t of T.
Vervang van dan af alle letters door hoofdletters als de tekst bestaat uit een oneven aantal tekens, door kleine letters als de tekst bestaat uit een even aantal tekens.
Geef een gepaste melding als er in de tekst geen t of T voorkomt.'''


def main():
    tekst = input("Geef een tekst in: ")
    positie = tekst.upper().find("T")
    if positie == -1:
        print("In de tekst komt geen 't' of 'T' voor.")
    else:
        nieuw = tekst[0:positie]
        if len(tekst) % 2 == 0:
            nieuw += tekst[positie:].lower()
        else:
            nieuw += tekst[positie:].upper()
        print(nieuw)


if __name__ == "__main__":
    main()
