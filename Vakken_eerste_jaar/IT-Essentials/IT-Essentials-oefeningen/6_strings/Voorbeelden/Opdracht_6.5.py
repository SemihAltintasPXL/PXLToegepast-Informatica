def main():
    naam = input("Geef je naam in ")
    voornaam = input("Geef je voornaam in ")
    nieuw = voornaam[0].upper() + "." + naam[0].upper() + naam[1:].lower()
    print("{} {} geeft {}".format(naam, voornaam, nieuw))


if __name__ == "__main__":
    main()
