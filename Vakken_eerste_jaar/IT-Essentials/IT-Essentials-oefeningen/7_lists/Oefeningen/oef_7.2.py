'''Creëer een list met 500 elementen waarbij de elementen willekeurige gehele getallen zijn tussen 0 en 10000 (beiden inclusief).

Als er minder dan de helft (250 elementen) van de getallen groter zijn dan 5000,
dan tel je alle elementen van de list die groter zijn dan 5000 op en druk het resultaat van deze optelling af.

Als er 250 of meer getallen groter zijn dan 5000,
dan tel je alle elementen van de list die groter zijn dan 8000 op en drukt dit resultaat af.'''

import random


def main():
    elementen = []
    teller = 0
    teller2 = 0
    optelling = 0
    optelling2 = 0
    for i in range(500):
        getal = random.randint(0, 10001)
        elementen.append(getal)
        if getal > 5000:
            teller += 1
            optelling += getal
            if getal > 8000:
                teller2 += 1
                optelling2 += getal
    print(elementen)

    if teller < 250:
        print("Som van alle elementen groter dan 5000 = ", optelling)

    else:
        print("Som van alle elementen groter dan 8000 = ", optelling2)


if __name__ == '__main__':
    main()
