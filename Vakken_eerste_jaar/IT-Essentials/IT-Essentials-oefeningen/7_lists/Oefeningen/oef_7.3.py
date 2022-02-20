'''Er worden via het toetsenbord 10 getallen ingelezen.
Schrijf een programma dat de positieve getallen toevoegt in een list met de naam positieve_getallen en de strikt negatieve getallen toevoegt in een list met de naam negatieve_getallen.

Druk de lengte en de waarden van beide lists af.
Bepaal het kleinste getal van de list negatieve_getallen.'''


def main():
    positieve_getallen = []
    negatieve_getallen = []
    kleinste_getal = 1  # een positief getal is genoeg omdat de kleinste getal al negatief is

    for i in range(10):
        getal = int(input("Geef een getal in "))
        if getal < 0:
            negatieve_getallen.append(getal)
            if getal < kleinste_getal:
                kleinste_getal = getal

        else:
            positieve_getallen.append(getal)

    print("{} positieve getallen in de lijst: {}".format(len(positieve_getallen), positieve_getallen))
    print("{} negatieve getallen in de lijst: {}".format(len(negatieve_getallen), negatieve_getallen))
    print("Het kleinste getal van de list negatieve_getallen is {}".format(kleinste_getal))


if __name__ == '__main__':
    main()
