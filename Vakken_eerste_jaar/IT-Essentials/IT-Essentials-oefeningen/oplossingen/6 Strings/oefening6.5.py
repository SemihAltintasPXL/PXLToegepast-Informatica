def bepaal_stad_code(hotelcode):
    return hotelcode[0:2]


def bereken_prijs_per_nacht_volwassene(hotelcode, aantal_sterren):
    if bepaal_stad_code(hotelcode) == "HI":
        return 70
    elif aantal_sterren in (4, 5):  # is hetzelfde als == 4 or == 5
        return 60
    elif bepaal_stad_code(hotelcode) in ("BR", "AN") and aantal_sterren == 3:
        return 60
    elif aantal_sterren == 3:
        return 56
    else:
        return 48


def bereken_prijs_per_nacht_kind(kindercode, hotelcode, aantal_sterren, prijs_volwassenen):
    if kindercode == "A":
        if aantal_sterren in (1, 2):
            return 0
        elif bepaal_stad_code(hotelcode) != "BR":
            return 0
    return prijs_volwassenen * 0.5


def main():
    aantal_volwassenen = int(input("Geef het aantal volwassenen in: "))
    aantal_kinderen = int(input("Geef het aantal kinderen in: "))
    hotelcode = input("Geef een hotelcode: ")
    overzicht_hotels = ""
    while hotelcode != "/":
        aantal_sterren = int(input("Geef het aantal sterren in: "))
        kindercode = input("Geef een kindercode in: ")
        while not (kindercode >= "A" and kindercode <= "Z"):
            print("foutieve kindercode, geef een nieuwe in")
            kindercode = input("Geef een kindercode in: ")
        prijs_per_nacht_per_volwassene = bereken_prijs_per_nacht_volwassene(hotelcode, aantal_sterren)
        prijs_per_nacht_per_kind = bereken_prijs_per_nacht_kind(kindercode, hotelcode, aantal_sterren,
                                                                prijs_per_nacht_per_volwassene)
        totaal_prijs = prijs_per_nacht_per_volwassene * aantal_volwassenen + prijs_per_nacht_per_kind * aantal_kinderen
        overzicht_hotels += "{:5}{:5} {:.2f} {:8.2f} {:.2f}\n".format(hotelcode, aantal_sterren * "*",
                                                                      prijs_per_nacht_per_volwassene,
                                                                      prijs_per_nacht_per_kind, totaal_prijs)
        hotelcode = input("Geef een hotelcode: ")
    print(overzicht_hotels)


if __name__ == '__main__':
    main()
