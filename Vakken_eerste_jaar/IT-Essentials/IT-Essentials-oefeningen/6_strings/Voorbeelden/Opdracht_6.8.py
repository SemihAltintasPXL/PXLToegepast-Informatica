def main():
    spreuk = "abracadabra"
    # vervang elke a door o
    spreuk = spreuk.replace("a", "o")
    print(spreuk)
    teller = 0
    for letter in spreuk:
        if letter == "o":
            teller += 1
    print("De letter o komt {} keer voor".format(teller))

    #  alternatieve gemakkelijkere manier
    print("De letter o komt {} keer voor".format(spreuk.count("o")))


if __name__ == "__main__":
    main()
