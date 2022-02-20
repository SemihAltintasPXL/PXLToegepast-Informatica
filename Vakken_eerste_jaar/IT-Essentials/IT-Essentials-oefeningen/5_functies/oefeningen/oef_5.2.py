'''Schrijf een functie die teruggeeft of een bepaald jaartal een schrikkeljaar is of niet.
Een schrikkeljaar is deelbaar door 4, maar niet deelbaar door 100.
Indien het jaar deelbaar is door 400 dan is het weer wel een schrikkeljaar.
Zorg ervoor dat het resultaat een boolean is.'''


def is_schrikkeljaar(jaartal):  # benaming van een functie die een boolean teruggeeft altijd met 'is' beginnen
    return jaartal % 4 == 0 and not jaartal % 100 == 0 or jaartal % 400 == 0


def main():
    jaartal = int(input("Geef een jaartal in: "))
    print(is_schrikkeljaar(jaartal))


if __name__ == '__main__':
    main()
