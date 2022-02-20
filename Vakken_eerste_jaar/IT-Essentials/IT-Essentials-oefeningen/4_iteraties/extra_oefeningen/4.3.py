naam = input("Geef de naam van de manager in ")
while naam != "xx" and naam != "XX":
    test1 = int(input("Resultaat eerste test: "))
    test2 = int(input("Resultaat tweede test: "))
    test3 = int(input("Resultaat derde test: "))

    gemiddelde = (test1 + test2 + test3) / 3

    if gemiddelde < 70:
        print("{} Test1: {}  Test2: {}  Test3: {}  Gemiddelde: {}  Resultaat: faalt".format(naam, test1, test2, test3,
                                                                                            gemiddelde))
    else:
        print("{} Test1: {}  Test2: {}  Test3: {}  Gemiddelde: {}  Resultaat: slaagt".format(naam, test1, test2, test3,
                                                                                             gemiddelde))
    naam = input("Geef de naam van de manager in ")
