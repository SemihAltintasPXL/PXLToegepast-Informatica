# Genereer 100 getallen > -5 en <15
# Hoeveel getallen wijken maximaal 2 af van get gemiddelde?

import random


def main():
    lijst = []
    for i in range(100):
        getal = random.randint(-4, 14)
        lijst.append(getal)
    gemiddelde = sum(lijst) / len(lijst)
    teller = 0
    for getal in lijst:
        # if getal <= gemiddeled + 2 and getal >= gemiddelde -2:

        if abs(getal - gemiddelde) < 2:
            teller += 1
    print("{} getallen wijken maximaal 2 af van het gemiddelde {:.1f}".format(teller, gemiddelde))


if __name__ == '__main__':
    main()
