''' Tel hoe vaak iedere letter voorkomt in een string (zonder verschil te maken tussen hoofd- en kleine letters).
    Je mag ieder teken dat geen letter is negeren.
    Print de letters met het aantal malen dat ze voorkomen.
    Print de letter wel enkel af indien de letter voorkomt in de oorspronkelijke tekst.     '''


def main():
    tekst = input("Geef een tekst in ").lower()
    for letter in range(ord("a"),
                        ord("z") + 1):  # is.alpha gaat ook om ervoor te zorgen dat enkel letters worden gebruikt
        if chr(letter) in tekst:
            print(chr(letter), "  aantal voorkomens:", tekst.count(chr(letter)))


if __name__ == '__main__':
    main()
