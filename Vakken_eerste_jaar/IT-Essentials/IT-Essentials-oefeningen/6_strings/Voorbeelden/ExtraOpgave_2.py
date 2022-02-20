# zie oefening 4.6: afdruk factuur onderaan met een mooie lay-out

def main():
    output = "{:^5}{:^3}{:^7}{:^8}\n".format("nr", "hoev", "ep", "bedrag")
    artikelnummer = int(input("Geef het artikelnummer in: "))
    som = 0
    while artikelnummer != 999:
        hoeveelheid = int(input("Geef de hoeveelheid in "))
        eenheidsprijs = int(input("Geef de eenheidsprijs in "))

        bedrag = hoeveelheid * eenheidsprijs
        output += "{:^5}{:3}{:7.2f}{:8.2f}\n".format(artikelnummer, hoeveelheid, eenheidsprijs, bedrag)

        som += bedrag

        artikelnummer = int(input("Geef het artikelnummer in: "))

    output += "Totaal te betalen bedrag is €{:<8.2f}:".format(som)
    print(output)


if __name__ == "__main__":
    main()
