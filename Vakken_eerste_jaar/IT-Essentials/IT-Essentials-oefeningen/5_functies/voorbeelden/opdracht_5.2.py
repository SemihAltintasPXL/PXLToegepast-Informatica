def druk_1regel(aantal, teken):
    for i in range(aantal):
        print(teken, end="")
    print()


def druk_rechthoek(hoogte, breedte, teken):
    for i in range(hoogte):
        druk_1regel(breedte, teken)


def main():
    # hoofdprogramma
    druk_1regel(10, "+")
    druk_1regel(100, "=")
    druk_rechthoek(4, 10, "+")
    druk_rechthoek(10, 5, "%")

    # gemakkelijkere oplossing die enkel in python werkt en niet in andere programeertalen (dit is niet de opgave)

    print(10 * "+")
    print(100 * "=")


if __name__ == '__main__':
    main()
