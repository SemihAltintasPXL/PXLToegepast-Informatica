# Genereer 2489 getallen >=0 en <=6
# Ga na dat elk getal ongeveer even vaak voorkomt.
# Druk het procentueel aandeel van elk getal af
# Bereken de som van al deze getallen
# 0 ==> maandag, 1 ==> dinsdag, 2==> woensdag .... 6 ==> zondag
import random


def main():
    teller = 7 * [0]  # een lijst met 7 tellers
    dagen = ["maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag"]
    som = 0
    for i in range(2489):
        getal = random.randint(0, 6)
        # som += getal      kan op een efficiëntere manier
        teller[getal] += 1
    for i in range(len(teller)):
        percentage = teller[i] / 2489 * 100
        som += i * teller[i]
        # print("getal {} komt {} keer voor. Dit is een aandeel van {:.2f}%". \
        #      format(i, teller[i], percentage))
        print("getal {} komt {} keer voor. Dit is een aandeel van {:.2f}%". \
              format(dagen[i], teller[i], percentage))
    print("de som van deze getallen is ", som)


if __name__ == '__main__':
    main()

