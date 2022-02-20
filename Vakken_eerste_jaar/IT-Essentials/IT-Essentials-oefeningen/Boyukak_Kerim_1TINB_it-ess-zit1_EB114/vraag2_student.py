def bereken_max_aantal_personen_mogelijk(gegevens_lijst):
    gegevens_gesplits = gegevens_lijst.split()
    aantal_sterren = gegevens_gesplits[2]
    oppervlakte = gegevens_gesplits[4]
    oppervlakte = int(oppervlakte[4:])

    if aantal_sterren == "****":
        max_aantal_personen = oppervlakte // 6 + 5

    elif aantal_sterren == "***":
        max_aantal_personen = oppervlakte // 5 + 4

    else:
        max_aantal_personen = oppervlakte // 4 + 3
    return max_aantal_personen


def get_afstand(gegevens_lijst):
    gegevens_gesplits = gegevens_lijst.split()
    afstand = gegevens_gesplits[5]
    afstand = int(afstand[8:])
    return afstand


def selecteer_appartementen(aantal_personen, balkon, maximum_afstand, lijst):
    nieuwe_lijst = []
    if maximum_afstand <= 30:
        nieuwe_lijst.append(lijst[0:5])

    elif maximum_afstand <= 300:
        nieuwe_lijst.append(lijst[0:5])
        nieuwe_lijst.append(lijst[7:12])
        nieuwe_lijst.append(lijst[15:18])

    elif maximum_afstand <= 500:
        nieuwe_lijst.append(lijst[0:5])
        nieuwe_lijst.append(lijst[7:12])
        nieuwe_lijst.append(lijst[15:18])
        nieuwe_lijst.append(lijst[13:14])
    else:
        nieuwe_lijst.append(lijst[::])


def maak_lijst_appartement_juiste_prijs(lijst):
    lijst_juiste_prijs =
    return lijst_juiste_prijs


def druk(lijst_juiste_prijs):


def main():
    lijst = ["Résidence Noeyms **** T0 opp:32 afstand:30  prijs 159",
             "Résidence Noemys **** T0 opp:28 balkon afstand:30 prijs 139",
             "Résidence Noemys **** T1 opp:34 afstand:30  prijs 148",
             "Résidence Noemys **** T3 opp:100 balkon afstand:30 prijs 431",
             "Résidence Noemys **** T1 opp:44 afstand:30 prijs 204",
             "Résidence Noemys **** T2 opp:50 afstand:30 balkon prijs 256",
             "Chalet L’Establou *** T3 opp:63 afstand:1200 prijs 208",
             "Résidence Odysee ** T1 opp:18 balkon afstand:300 prijs 83",
             "Résidence Odysee ** T3 opp:60  afstand:300 balkon prijs 139",
             "Ski Constellation *** T1 opp:30 afstand:250 prijs 105",
             "Ski Constellation *** T0 opp:30 afstand:250 balkon prijs 110",
             "Ski Constellation *** T2 opp:50 afstand:250 prijs 210",
             "Ski Constellation *** T3 opp:101 afstand:250 prijs 390",
             "Résidence Vacancéole Véga *** T1 opp:44 afstand:500 prijs 82",
             "Résidence Vacancéole Véga *** T3 opp:74 afstand:500 prijs 152",
             "Résidence Reneb ** T1 opp:22 afstand:250 prijs 72",
             "Résidence Reneb ** T0 opp:18 balkon afstand:250 prijs 83",
             "Résidence Pégase ** T1 opp:26 afstand:300 prijs 62",
             "Résidence Pégase ** T0 opp:25 afstand:300 prijs 60"]
    aantal_personen = int(input("Geef het gewenst aantal personen in "))
    balkon = input("Wens je een balkon? ")
    maximum_afstand = int(input("Geef de maximale afstand in meter tot de skipiste "))
    periode = input("Geef de gewenste periode in ")
    """lijst_ok = selecteer_appartementen(lijst, aantal_personen, balkon, maximum_afstand)
    if len(lijst_ok) == 0:
        print("Er zijn geen appartementen die voldoen aan je eisen.")
    else:
        druk(lijst_ok, "Lijst van de appartementen die aan de criteria voldoen")
        lijst_juiste_prijs = appartement_juiste_prijs(lijst_ok, periode)
        druk(lijst_juiste_prijs, "Lijst van de appartementen die aan de criteria voldoen met de prijs voor de gevraagde periode") """


if __name__ == '__main__':
    main()
