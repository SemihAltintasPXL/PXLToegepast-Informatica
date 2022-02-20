# Maak een geneste list van 4 rijen en 6 kolommen.
# Vul geneste list met het product van rijnummer met kolomnummer.
# Druk deze rij per rij af

# Bereken de som van de kolommen
# Bereken de som van de rijen

def maak_lijst(aantal_rij, aantal_kolom):
    lijst = []
    for rijnr in range(1, aantal_rij + 1):
        rij = []
        for kolnr in range(1, aantal_kolom + 1):
            rij.append(rijnr * kolnr)
        lijst.append(rij)
    for rij in lijst:
        return lijst


def som_kolom(lijst):
    som_lijst = []
    for j in range(len(lijst[0])):  # kolom per kolom
        som = 0
        for i in range(len(lijst)):  # alle rijen doorlopen
            som += lijst[i][j]
        som_lijst.append(som)
    return som_lijst


def som_rij(lijst):  # som per rij berekenen op andere manier als in som_kolom
    som_lijst = []
    for rij in lijst:  # een rij is een list => je kan gebruik maken van ingebouwde functie sum (ALLEEN BIJ RIJEN,NIET KOLOMMEN)
        som_lijst.append(sum(rij))
    return som_lijst


def main():
    lijst = maak_lijst(4, 6)
    # alles afdrukken in 1 keer
    print(lijst)
    # rij per rij afdrukken
    for rij in lijst:
        print(rij)
    print("de som per kolom", som_kolom(lijst))
    print("de som per rij", som_rij(lijst))


# 'i' VOOR RIJEN , 'j' VOOR KOLOMMEN

if __name__ == "__main__":
    main()
