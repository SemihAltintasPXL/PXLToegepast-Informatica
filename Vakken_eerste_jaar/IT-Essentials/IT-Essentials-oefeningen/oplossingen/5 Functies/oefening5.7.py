
def bereken_boete():
    naam = input("Geef uw naam in: ")
    aantal = 0
    while not (naam == "xx"):
        aantal_boeken = int(input("Geef het aantal boeken in: "))
        aantal_dagen_overschreden = int(input("Geef het aantal dagen dat de boeken zijn overschreden: "))
        boete = (aantal_dagen_overschreden * 0.07) * aantal_boeken
        if aantal_dagen_overschreden >= 45:
            boete = boete + ((aantal_dagen_overschreden - 44) * 0.84)
            aantal = aantal_dagen_overschreden - 44
        print("de boete die u moet betalen is", boete, "en de aantal aanmaningsbrieven die zijn verstuurd is", aantal)
        naam = input("Geef uw naam in: ")


def main():
    bereken_boete()


if __name__ == '__main__':
    main()