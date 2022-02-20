def controleer_hoogte():
    hoogte = int(input("Geef de hoogte in die jij wil springen "))
    hoogte2 = int(input("Ben je zeker? Geef de hoogte in die je wil springen"))
    while hoogte2 != hoogte:
        hoogte2 = int(input("Je hebt twee keer een andere hoogte ingegeven. Wat wil je nu precies? "))
    return hoogte2


def bepaal_aantal_wortels(aantal_paarden, hoogte, aantal_hoogste):
    basis_aantal = aantal_paarden * 2

    if aantal_hoogste // 2 < hoogte == 110:
        basis_aantal += basis_aantal * 0.30

    elif hoogte != 50 and hoogte != 70 and hoogte != 90 and hoogte != 110:
        basis_aantal -= int(basis_aantal * 0.20)

    return basis_aantal


def print_aantal_wortels(aantal_wortels):
    lijst = ["", "W", "O", "R", "T", "E", "L"]
    woord = ''
    for i in range(1, aantal_wortels + 1):

        for j in range(i):
            woord += lijst[i]
            print(woord, end="")
            if lijst[i] > lijst[6]:
                lijst[i] = lijst[1]
        print()


def main():
    aantal_paarden = 0
    aantal_hoogste = 0
    hoogte = 0  # moest initialiseren
    naam_paard = input("Geef de naam van het paard in ")
    while aantal_paarden < 8 or (aantal_paarden < 3 and naam_paard.count(naam_paard) != 2):
        hoogte = controleer_hoogte()
        if hoogte == 110:
            aantal_hoogste = +1

        aantal_paarden += 1
        naam_paard = input("Geef de naam van het paard in ")

    aantal_wortels = bepaal_aantal_wortels(aantal_paarden, hoogte, aantal_hoogste)

    print("Het aantal wortels is {}".format(aantal_wortels))
    print("Het aantal deelnemende paarden is {} ".format(aantal_paarden))
    print_aantal_wortels(aantal_wortels)


if __name__ == '__main__':
    main()
