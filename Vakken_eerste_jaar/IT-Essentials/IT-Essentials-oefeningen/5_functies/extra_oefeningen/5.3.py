import random


def is_perfectGetal(getal):
    som = 0
    for i in range(getal, 1, -1):
        if getal % i == 0:
            som += getal // i
    if som == getal:
        print(getal, "is een perfect getal")
    else:
        print(getal, "is geen perfect getal")


def random_getal():
    cijfer1 = random.randint(1, 3)
    cijfer2 = random.randint(1, 3) * 10
    cijfer3 = random.randint(1, 3) * 100
    cijfer4 = random.randint(1, 3) * 1000
    getal = cijfer1 + cijfer2 + cijfer3 + cijfer4
    return getal


def main():
    getal = random.randint(1, 100)
    is_perfectGetal(getal)

    random_getal()
    is_perfectGetal(random_getal())


if __name__ == '__main__':
    main()
