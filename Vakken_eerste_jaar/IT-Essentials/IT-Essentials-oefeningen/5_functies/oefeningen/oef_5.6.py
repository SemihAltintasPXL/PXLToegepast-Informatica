'''Schrijf een programma om huiswerk te genereren voor kinderen van het eerste leerjaar.
We gaan ervan uit dat ze kunnen tellen tot 20.
Het huiswerk gaat over het inoefenen van de bewerking aftrekking.
Om de kinderen niet in de war te brengen zorgen we dat enkel oefeningen waarvan het resultaat groter of gelijk is aan nul als output worden gegenereerd.
Er worden verschillende reeksen gemaakt. Reeks 1, reeks 2 tot en met reeks 5.
Elke reeks bevat 5 oefeningen. De output moet als volgt eruit zien:

reeks 1
1) 11 – 2 =
2) 20 – 9 =
3) 2 – 0 =
4) 14 – 11 =
5) 5 – 5 =

reeks 2
…'''

import random


def berekening_huiswerk():
    for i in range(1, 6):  # 5 reeksen
        print("Reeks", i)
        for j in range(1, 6):  # 5 oefenigen per reeks
            getal1 = random.randint(0, 20)
            getal2 = random.randint(0, getal1)
            som = getal1 - getal2
            print(j, ")", getal1, "-", getal2, "=", som)
        print()


def main():
    berekening_huiswerk()


if __name__ == "__main__":
    main()
