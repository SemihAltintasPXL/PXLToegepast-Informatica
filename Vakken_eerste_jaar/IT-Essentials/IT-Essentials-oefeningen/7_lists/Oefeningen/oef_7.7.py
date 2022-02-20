def bereken_punten(juiste_antwoorden, antwoorden):
    punten = 20
    for i in range(len(antwoorden)):
        if antwoorden[i] == juiste_antwoorden[i]:
            punten += 2
        elif antwoorden[i] != "E":
            punten -= 1
    return punten


def bepaal_leeftijd(geboortedatum, huidige_datum):
    huidige_split = huidige_datum.split("/")
    huidige_dag = huidige_split[0]
    huidige_maand = huidige_split[1]
    huidig_jaar = huidige_split[2]

    geboorte_split = geboortedatum.split("/")
    geboorte_dag = geboorte_split[0]
    geboorte_maand = geboorte_split[1]
    geboorte_jaar = geboorte_split[2]

    leeftijd = int(huidig_jaar) - int(geboorte_jaar)
    if int(huidige_maand) < int(geboorte_maand):
        leeftijd -= 1
    elif int(huidige_maand) == int(geboorte_maand) and int(huidige_dag) < int(geboorte_dag):
        leeftijd -= 1
    return leeftijd


def omzetting_tijd(tijd):
    uur = tijd // 3600
    tijd %= 3600
    min = tijd // 60
    tijd %= 60
    if tijd >= 30:
        min += 1
        if min == 60:
            min = 0
            uur += 1
    return "{}u{:02}m".format(uur, min)


def main():
    output = ""
    teller = 0
    juiste_antwoorden = input("Geef de 10 juiste antwoorden achter elkaar in ")
    huidige_datum = input("geef de huidige datum in (dd/mm/yyyy) ")
    gegevens_deelnemer = input("geef het deelnemersnummer,geboortedatum,antwoorden en de tijd in seconden in ")
    while gegevens_deelnemer != "0":
        gegevens_gesplits = gegevens_deelnemer.split()
        deelnemersnummer = gegevens_gesplits[0]
        geboortedatum = gegevens_gesplits[1]
        antwoorden = gegevens_gesplits[2]
        tijd_in_s = int(gegevens_gesplits[3])

        teller += 1
        punten = bereken_punten(juiste_antwoorden, antwoorden)
        tijd = omzetting_tijd(tijd_in_s)
        leeftijd = bepaal_leeftijd(geboortedatum, huidige_datum)

        output += "{:2}.  {:4}  {:2} jaar  {:5}  {:2} ptn\n".format(teller, deelnemersnummer, leeftijd, tijd, punten)

        gegevens_deelnemer = input("geef het deelnemersnummer,geboortedatum,antwoorden en de tijd in seconden in ")

    print(output)


if __name__ == '__main__':
    main()
