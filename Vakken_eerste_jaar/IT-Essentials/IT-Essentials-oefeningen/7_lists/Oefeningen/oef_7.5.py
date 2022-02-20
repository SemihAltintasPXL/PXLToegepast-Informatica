'''Schrijf een programma om de verkiezingsresultaten van de verkiezing “student van het jaar” te verwerken. Er zijn 4 kandidaten waarop men kan stemmen.
Via het toetsenbord wordt de keuze van een aantal personen ingegeven. De keuze is de code van de student waarvoor men stemt.
De invoer stopt wanneer voor de keuze de waarde 0 wordt ingegeven.

code 1: An Janssen
code 2: Bart Vriends
code 3: Andries Michels
code 4: Inge Kaas

Druk per kandidaat de naam, het aantal personen dat voor deze kandidaat gestemd heeft en het procentueel aandeel van de gekregen stemmen in het totaal aantal uitgebrachte stemmen af.
Het procentueel aandeel wordt weergegeven met 1 cijfer na de komma.'''


def main():
    namen = ["", "An Janssen", "Bart Vriends", "Andries Michels", "Inge Kaas"]
    tellers = [
                  0] * 5  # lijst met 4 tellers om de stemmen van elke code te tellen (1-4)    + de lege string om zo positie 1 aan code 1 te gegeven (positie 0 is de lege string)

    invoer = int(input("Geef je stemcode: "))
    while invoer != 0:
        tellers[invoer] += 1
        invoer = int(input("Geef je stemcode: "))

    aantal_stemmen = sum(tellers)
    for i in range(1, len(tellers)):
        perc = tellers[i] / aantal_stemmen * 100
        print("{} heeft {} stemmen gekregen met {:.1f}%".format(namen[i], tellers[i], perc))

    '''
    procent_an = round(tellers[0] / aantal_stemmen * 100, 1)
    procent_bart = round(tellers[1] / aantal_stemmen * 100, 1)
    procent_andries = round(tellers[2] / aantal_stemmen * 100, 1)
    procent_kaas = round(tellers[3] / aantal_stemmen * 100, 1)
    print("An Janssen heeft", tellers[0], "stem(men) gekregen met", procent_an, "%")
    print("Bart Vriends heeft", tellers[1], "stem(men) gekregen met", procent_bart, "%")
    print("Andries Michels heeft", tellers[2], "stem(men) gekregen met", procent_andries, "%")
    print("Inge Kaas heeft", tellers[3], "stem(men) gekregen met", procent_kaas, "%")
    --> de code zonder deze gegevens in een lijst te zetten (minder efficiënt)  '''

    print(tellers)


if __name__ == '__main__':
    main()
