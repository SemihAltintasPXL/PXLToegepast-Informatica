def toon_bord(spelbord):
    print(" 1 2 3")
    for rij in range(3):
        print(rij + 1, end=" ")
        for kol in range(3):
            print(spelbord[rij][kol], end=" ")
        print()
