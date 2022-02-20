'''Schrijf een programma om een ingevoerde tekst te encrypteren.
Bij elke ascii waarde van het teken wordt een getal bijgeteld.
Dit getal is een willekeurig geheel getal >=2 en <=24 en moet een veelvoud zijn van 2.
Maak voor het encrypteren gebruik van een functie met de ingevoerde tekst en het gegenereerde getal als parameters.
Deze functie heeft de geëncrypteerde tekst als uitvoer.
Vb “dit is een belangrijke tekst” wordt dan “hmx$mw$iir$fiperkvmnoi$xiowx” als het gegenereerde getal gelijk is aan 4.'''

import random


def encrypteer(tekst, getal):
    nieuw = ""
    for teken in tekst:
        nieuw += chr(ord(teken) + getal)
    return nieuw


def main():
    tekst = input("Geef een tekst in ")
    getal = random.randrange(2, 25, 2)  # beter:   random.randint(1,12) *2      randrange enkel in python
    encrypteer(tekst, getal)


if __name__ == '__main__':
    main()
