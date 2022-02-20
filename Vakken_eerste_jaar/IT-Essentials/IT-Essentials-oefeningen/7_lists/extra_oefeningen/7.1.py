def main():
    ingave = input("Geef de klascode, betaalde voorschot, aantal studenten en klasnummer in ")
    gegevens = ingave.split()
    klascode = gegevens[0]
    voorschotbedrag = int(gegevens[1])
    aantal_studenten = int(gegevens[2])
    onkosten = aantal_studenten * [0]
    student_nr = int(gegevens[3])
    print(klascode, voorschotbedrag, aantal_studenten, student_nr)
    teller = 4
    while student_nr != 0:
        onkosten[student_nr - 1] += int(gegevens[teller])
        student_nr = int(gegevens[teller + 1])
        teller += 2
    print("Saldi voor klas", klascode)
    for i in range(aantal_studenten):
        print("Student {}: onkosten: {} saldo: {}".format(i + 1, onkosten[i], voorschotbedrag - onkosten[i]))
        print("Student {}: onkosten: {} saldo: {}".format(i + 1, onkosten[i], voorschotbedrag - onkosten[i]))


if __name__ == '__main__':
    main()
