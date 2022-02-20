'''Schrijf een functie om volgende schermafdruk te bekomen.

R
S T
U V W
X Y Z A
B C D E F
De grootte van de driehoek en de beginletter kunnen variëren en wordt als gegeven via het toetsenbord ingegeven.
Indien je voorbij Z bent, moet je verdergaan vanaf A.'''


def teken_driehoek(grootte, beginletter):
    for i in range(1, grootte + 1):

        for j in range(i):
            print(beginletter, end=" ")
            beginletter = chr(ord(beginletter) + 1)
            if beginletter > "Z":
                beginletter = "A"
        print()


def main():
    grootte = int(input("Geef de grootte van de driehoek in: "))
    beginletter = input("Geef de beginletter in: ")
    teken_driehoek(grootte, beginletter)


if __name__ == '__main__':
    main()
