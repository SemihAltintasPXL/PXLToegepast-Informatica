def bereken_prioriteit(inkomen_man, inkomen_vrouw, aantal_kinderen, code):
    if inkomen_man + inkomen_vrouw < 2000 and aantal_kinderen >= 3:
        prioriteit = 1
    elif inkomen_man + inkomen_vrouw < 2000 and aantal_kinderen < 3:
        prioriteit = 2
    elif inkomen_man + inkomen_vrouw >= 2000 and inkomen_man + inkomen_vrouw < 2500:
        prioriteit = 3
    else:
        prioriteit = 4
    if code == "J2017" or code == "J2018" or code == "J2019" or code == "J2020" or code == "J2021":
        prioriteit = 5
    return prioriteit * "*"


def bepalen_goedkopere_bouwlening(aantal_kinderen, naam_man, naam_vrouw, inkomen_man, inkomen_vrouw):
    if (naam_man == "xx" or naam_vrouw == "xx") and (aantal_kinderen <= 1 or inkomen_man + inkomen_vrouw <= 1500):
        print("J")
    else:
        print()


def main():
    aantal_sociale_woning = 0
    aantal_kopers = 0
    output = ""
    code = input("Geef een code in (J gevolgd noor 4 cijfers / N )  ")
    while code != "S":
        naam_man = input("Geef de naam van de man in (achternaam spatie voornaam) ")
        naam_vrouw = input("Geef de naam van de vrouw in (achternaam spatie voornaam) ")
        inkomen_man = int(input("Geef de inkomen van de man in "))
        inkomen_vrouw = int(input("Geef de inkomen van de vrouw in "))
        aantal_kinderen = int(input("Geef het aantal kinderen in "))

        aantal_kopers += 1
        if code != "N":
            aantal_sociale_woning += 1

        prioriteit = bereken_prioriteit(inkomen_man, inkomen_vrouw, aantal_kinderen, code)
        bouwlening = bepalen_goedkopere_bouwlening(aantal_kinderen, naam_man, naam_vrouw, inkomen_man, inkomen_vrouw)

        if naam_man == "xx":
            output += "{:<3} {:<40} {:<10} {:<10}\n".format(aantal_kopers, naam_vrouw, prioriteit, bouwlening)
        elif naam_vrouw == "xx":
            output += "{:<3} {:<40} {:<10} {:<10}\n".format(aantal_kopers, naam_man, prioriteit, bouwlening)
        else:
            output += "{:<3} {:<40} {:<10} {:<10}\n".format(aantal_kopers, naam_man + naam_vrouw, prioriteit,
                                                            bouwlening)

        code = input("Geef een code in ")

    perc_sociale_woning = round(aantal_sociale_woning / aantal_kopers, 1)
    print("{:<3} {:<40} {:<10} {:<10}\n".format("nr", "familienaam", "prioriteit", "bouwlening"))
    print(output)
    print("{} % van de kandidaat kopers wonen in een sociale woning.".format(perc_sociale_woning))


if __name__ == '__main__':
    main()

# KIJK BB VOOR OPLOSSING WANT DIT IS KKR LANG