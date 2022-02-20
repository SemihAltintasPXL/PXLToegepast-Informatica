def druk_1regel(aantal, teken):
    for i in range(aantal):
        print(teken, end="")
    print()


def main():
    # hoofdprogramma
    druk_1regel(10, "t")
    druk_1regel(100, "=")

    # gemakkelijkere oplossing werkt alleen in Python (dit is niet de opgave)
    print(10 * "+")
    print(100 * "=")


if __name__ == '__main__':
    main()
