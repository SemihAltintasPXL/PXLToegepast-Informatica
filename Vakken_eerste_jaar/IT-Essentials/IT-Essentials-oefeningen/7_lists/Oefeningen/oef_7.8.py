def main():
    AANTAL_STUDENTEN = 5
    AANTAL_VAKKEN = 4

    punten = []

    for studenten in range(AANTAL_STUDENTEN):
        punten_studenten = []
        print("Geef het punt in voor student" + str(studenten + 1))
        for vakken in range(AANTAL_VAKKEN):
            punt = int(input("vak " + str(vakken + 1) + ": "))
            punten_studenten.append(punt)
        punten.append(punten_studenten)

    for vak in range(AANTAL_VAKKEN):
        laagste = punten[0][vak]

        student_laagste_score = 1
        som = punten[0][0]
        for studenten in range(AANTAL_STUDENTEN):
            if punten[studenten][vak] < laagste:
                laagste = punten[studenten][vak]
                student_laagste_score = studenten + 1
            som += punten[studenten][vak]
        gemiddelde = som / AANTAL_STUDENTEN
        print(
            "vak {0} gemiddelde score: {1:.1f} Laagste score: {2} behaald door student, {3}".format(vak + 1, gemiddelde,
                                                                                                    laagste,
                                                                                                    student_laagste_score))


if __name__ == '__main__':
    main()
