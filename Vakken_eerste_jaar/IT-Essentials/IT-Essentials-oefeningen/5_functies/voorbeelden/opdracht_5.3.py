def printx():
    print("x", end="")  # worden op eenzelfde regel afgedrukt


def meerderex(aantal):
    for i in range(aantal):
        printx()
    print()


def main():
    meerderex(10)
    # mag ook in de functie meerderex gezet worden
    meerderex(100)

    # gemakkelijkere oplossing maar niet de opgave
    print(10 * "x")
    print(100 * "x")


if __name__ == '__main__':
    main()
