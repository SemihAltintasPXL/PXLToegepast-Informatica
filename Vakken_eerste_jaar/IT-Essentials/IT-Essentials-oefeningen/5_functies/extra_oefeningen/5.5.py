def bereken_kinderbijslag(aantal_kinderen, code, leeftijd):
    if code == "H":
        bedrag = 300

    else:
        bedrag = 75

    if aantal_kinderen > 1:
        bedrag += aantal_kinderen * 70
    if leeftijd > 12:
        bedrag += 50
    elif leeftijd > 6:
        bedrag += 25
    return bedrag


def main():
    kinderbijslag = 0
    aantal_kinderen = int(input("Geef het aantal kinderen in "))
    for kind in range(aantal_kinderen):
        leeftijd = int(input("Geef de leeftijd van het kind in "))
        code = input("Geef de code in ( H = kind met handicap, anders laat je dit leeg) ")
        kinderbijslag += bereken_kinderbijslag(aantal_kinderen, code, leeftijd)
    print("De totale kinderbijslag bedraagt", kinderbijslag, "euro")


if __name__ == '__main__':
    main()
