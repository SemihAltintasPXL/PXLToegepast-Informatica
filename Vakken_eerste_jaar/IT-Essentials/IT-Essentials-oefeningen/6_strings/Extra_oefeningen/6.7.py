def controleer_productcode(productcode):
    while not (productcode[0] == "l" or productcode[0] == "L" or productcode[0] == "r" or productcode[0] == "R"):
        productcode = input("De productcode begint niet met l,L,r,R ")

    while len(productcode) != 8:
        productcode = input("De productcode bevat niet het juist aantal tekens ")

    while not (productcode[6:] == "bo" or productcode[6:] == "on"):
        productcode = input("De productcode eindingt niet met 'bo' of 'on' ")

    print(True)


def main():
    productcode = input("Geef het de productcode in ")
    controleer_productcode(productcode)


if __name__ == '__main__':
    main()
