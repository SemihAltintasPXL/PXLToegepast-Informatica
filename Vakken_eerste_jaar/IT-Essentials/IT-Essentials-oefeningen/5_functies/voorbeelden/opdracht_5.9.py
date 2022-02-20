import random


def main():
    # extra: hoe kan je ervoor zorgen dat elke student dezelfde reeks getallen heeft
    random.seed(1236)
    # genereer een willekeurig gegeel getal >= 0 en <= 10
    getal = random.randint(0, 10)
    print(getal)

    # genereer een willekeurig geheel getal >0 en <10 ==> >=1 en <= 9
    for i in range(10):
        print(random.randint(1, 9))

    # genereer een willekeurig geheel getal >= -200 en <= 1000 veelvoud van 10
    getal2 = random.randint(-20, 100) * 10
    print(getal2)

    # gemakkelijkere oplossing maar werkt alleen in Python!!!
    # functie kiest een willekeurig getal uit ed range(start,stop,stap)
    getal3 = random.randrange(-200, 1010, 10)
    print(getal3)

    # genereer een willekeurig reëel getal >=0 en <100 met 1 cijfer na de komme
    getal4 = random.randint(0, 999) / 10
    print(getal4)


if __name__ == '__main__':
    main()
