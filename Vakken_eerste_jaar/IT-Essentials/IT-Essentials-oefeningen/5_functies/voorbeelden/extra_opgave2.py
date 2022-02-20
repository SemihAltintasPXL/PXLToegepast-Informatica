# zie extra opgave 4 in hoofdstuk 4

# maak volgende driehoek
# 1 2 3 4 5
# 1 2 3 4
# 1 2 3
# 1 2
# 1

# maak een functie om de driehoek te tekenen (grootte is variabel)
# maak een functie die de som berekent van de getallen in de driehoek

def teken_driehoek(grootte):
    for i in range(1, grootte + 1):
        for j in range(1, grootte + 2 - i):
            print(j, end="\t")  # end = "\t" is tab , om het mooi uit te lijnen
        print()


def bereken_som_driehoek(grootte):
    som = 0
    for i in range(1, grootte + 1):
        for j in range(1, grootte + 2 - i):
            som += j
    return som


def main():
    teken_driehoek(5)
    print("de som van de getallen in deze driehoek", bereken_som_driehoek(5))

    teken_driehoek(15)
    print("de som van de getallen van driehoek2", bereken_som_driehoek(15))


if __name__ == "__main__":
    main()
