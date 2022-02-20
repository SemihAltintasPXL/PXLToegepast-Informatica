'''Er wordt een willekeurig geheel getal gegenereerd tussen 1 en 10 (grenzen inclusief) waarna de gebruiker dit mag proberen te raden.
De computer geeft feedback: “hoger”, “lager” of “proficiat, getal geraden”.
Maak voor het geven van de feedback gebruik van een functie. De speler mag slechts 4 keer raden!
Het spel stopt als het getal geraden is, of als de 4 beurten om zijn.'''

import random


def feedback(getal, willekeurig):
    if getal < willekeurig:
        print("Hoger!")
    if getal > willekeurig:
        print("Lager!")
    if getal == willekeurig:
        print("Proficiat, getal geraden!")


def main():
    teller = 1
    willekeurig = random.randint(0, 10)
    getal = int(input("Raad het getal tussen 1 en 10 "))
    while not (teller == 4 or getal == willekeurig):
        teller += 1
        feedback(getal, willekeurig)
        getal = int(input("Raad het getal tussen 1 en 10 "))


if __name__ == "__main__":
    main()
