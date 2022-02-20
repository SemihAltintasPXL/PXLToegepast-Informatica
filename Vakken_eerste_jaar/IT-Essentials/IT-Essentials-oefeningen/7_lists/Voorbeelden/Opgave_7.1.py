def main():
    fruitlijst = ["appel", "banaan", "kers", "doerian"]
    i = 0
    while i < len(fruitlijst):
        print(fruitlijst[i])
        if fruitlijst[i] == "kers":
            fruitlijst[i] = "kriek"
        i += 1
    print(fruitlijst)
    # als je 1 element wil wijzigen in de lijst,
    # kan je geen gebruik maken van onderstaande
    # de wijziging in R12 wordt niet uitgevoerd!!!!
    fruitlijst = ["appel", "banaan", "kers", "doerian"]
    for fruit in fruitlijst:
        print(fruit)
        if fruit == "kers":
            fruit = "kriek"
    print(fruitlijst)


if __name__ == '__main__':
    main()
