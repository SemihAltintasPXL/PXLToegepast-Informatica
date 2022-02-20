'''In een bibliotheek wordt een programma gebruikt om de boete te bepalen voor het verstrijken van de uitleentermijn.
Per bibliotheekgebruiker (die de termijn overschrijdt) geeft men via het toetsenbord in:
zijn naam (‘xx’ om te eindigen), het aantal boeken, het aantal dagen dat de uitleentermijn overschreden is.
De boete bedraagt 0,07 euro per boek per dag.
Bovendien wordt automatisch vanaf de 45ste dag dat de termijn overschreden werd een aanmaningsbrief opgestuurd, die 0,84 euro kost.
De kosten voor het versturen van de aanmaningsbrief worden bij de boete opgeteld.
De berekening van de boete gebeurt in een functie. Per persoon wordt de boete afgedrukt.
De bibliotheek wenst eveneens te weten hoeveel aanmaningsbrieven er verstuurd werden.'''


def berekening_boete(aantal_boeken, aantal_dagen):
    aantal_aanmaningsbrieven = 0
    boete = aantal_boeken * aantal_dagen * 0.07

    if aantal_dagen >= 45:
        boete = boete + (aantal_dagen - 44) * 0.84
        aantal_aanmaningsbrieven = aantal_dagen - 44

    print("Uw boete bedraagt", boete, "euro \nAantal aanmaningsbrieven: ", aantal_aanmaningsbrieven)


def main():
    naam = input("Naam: ")
    while naam != "xx":
        aantal_boeken = int(input("Aantal boeken: "))
        aantal_dagen = int(input("Aantal dagen dat de uitleentermijn overschreden is "))
        berekening_boete(aantal_boeken, aantal_dagen)
        naam = input("Naam: ")


if __name__ == "__main__":
    main()
