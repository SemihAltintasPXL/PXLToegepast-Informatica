def main():
    woord = input("Geef een woord in ")
    if len(woord) % 2 == 0:
        index1 = len(woord) // 2 - 1
        index2 = index1 + 2
    else:
        index1 = len(woord) // 2
        index2 = index1 + 1

    deel1 = woord[0:index1]
    deel2 = woord[index1:index2].upper()
    deel3 = woord[index2:]
    nieuw = deel1 + deel2 + deel3
    print(nieuw)


if __name__ == "__main__":
    main()
