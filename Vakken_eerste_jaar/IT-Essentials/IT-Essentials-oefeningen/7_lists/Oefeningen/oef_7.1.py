'''Geef 15 gehele getallen in via het toetsenbord. Druk het gemiddelde af weergegeven met 1 cijfer na de komma.
Hoeveel getallen zijn er kleiner dan het gemiddelde van deze 15 getallen? Hoeveel procent is dit van de ingegeven getallen?'''


def main():
    getallen = []
    som = 0
    for i in range(15):
        getal = int(input("Geef een getal in "))
        som += getal
        getallen.append(getal)
    gemiddelde = som / len(getallen)
    print("Het gemiddelde is {:.1f}".format(gemiddelde))
    teller = 0
    for getal in getallen:
        if getal < gemiddelde:
            teller += 1
    percentage = (teller / len(getallen)) * 100
    print(
        "{} getallen zijn kleiner dan het gemiddelde. Dit is {}% van de ingegeven getallen".format(teller, percentage))


if __name__ == '__main__':
    main()
