def toon_tafel(getal):
    for i in range(11):
        print(i, "x", getal, "=", i * getal)


def main():
    getal = int(input("Welke tafel wil je zien? "))
    toon_tafel(getal)


if __name__ == '__main__':
    main()

