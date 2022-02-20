'''Een studentenvereniging heeft aan zijn leden een lidnummer gegeven.
Dit lidnummer bestaat uit 7 cijfers (dit is geen String en hierop moet je geen controle uitvoeren).
Wanneer het getal bestaande uit het 2de en het 4de cijfer gelijk is aan de 2 laatste cijfers dan mag de student gratis binnen op een fuif.

Schrijf hiervoor een functie controleer. Deze functie heeft een lidnummer als invoerparameter en geeft "gratis" of "niet gratis" als uitvoer.

Voorbeeld: 1734568. Hier is het getal gevormd door het 2de en 4de cijfer (=74) niet gelijk aan het getal gevormd door de 2 laatste cijfers (=68).
Dit lid moet inkom betalen.'''

import random


def controleer(lidnummer):
    if int(lidnummer / 100000) % 10 == int(lidnummer / 10) % 10 and int(lidnummer / 1000) % 10 == int(
            lidnummer % 10):  # om de positie te weten van decimalen na de komma --> * ipv /
        return "Inkom is gratis!"
    else:
        return "Inkom is niet gratis!"


def main():
    lidnummer = random.randint(1000000, 9999999)
    print("Je lidnummer is:", lidnummer)
    print(controleer(lidnummer))

    if __name__ == "__main__":
        main()
