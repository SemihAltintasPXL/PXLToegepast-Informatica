def main():
    antwoorden = [[52, 36, 55, 46, 38],
                  [35, 45, 54, 65, 1],
                  [75, 66, 44, 10, 5],
                  [23, 33, 45, 50, 49]]
    vragen = ["Vraag1", "Vraag2", "Vraag3", "Vraag4"]
    meningen = ["Volledig oneens", "Eerder oneens", "Geen mening", "Eerder eens", "Volledig eens"]

    vraag_hoogste_gemiddelde = 0
    for j in range(len(vragen)):
        score = 0
        gewogen_gemiddelde = 0
        hoogste_gemiddelde = 0

        for i in range(len(meningen)):
            score += 1
            gewogen_gemiddelde += (score * antwoorden[j][i]) / 200
            if gewogen_gemiddelde > hoogste_gemiddelde:
                hoogste_gemiddelde = gewogen_gemiddelde
                vraag_hoogste_gemiddelde = j + 1

        print("Het gewogen gemiddelde van vraag {} = {:.2f}".format(j + 1, gewogen_gemiddelde))
    print("Het hoogst gewogen gemiddelde is op vraag {}".format(vraag_hoogste_gemiddelde))


if __name__ == '__main__':
    main()
