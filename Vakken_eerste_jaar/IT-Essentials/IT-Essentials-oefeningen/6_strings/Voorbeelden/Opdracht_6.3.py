def main():
    string1 = input("geef een eerste woord in ")
    string2 = input("geef een tweede woord in ")
    if len(string1) < len(string2):
        lengte = len(string1)
    else:
        lengte = len(string2)

    # gemakkelijkere manier om lengte te bepalen => ingebouwde functie min   (minimum, kleinste tussen de 2)
    lengte = min(len(string1), len(string2))

    for i in range(lengte):
        if string1[i] == string2[i]:
            print("{} op index {}".format(string1[i], i))


if __name__ == "__main__":
    main()
