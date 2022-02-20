def main():
    lijst = []
    som = 0
    for i in range(10):
        getal = int(input("geef een getal in "))
        som += getal
        lijst.append(getal)
    gemiddelde = som / len(lijst)
    teller = 0
    for getal in lijst:
        if getal < gemiddelde:
            teller += 1
    print("{} getallen zijn kleiner dan het gemiddelde {:f}".format(teller, gemiddelde))


if __name__ == '__main__':
    main()