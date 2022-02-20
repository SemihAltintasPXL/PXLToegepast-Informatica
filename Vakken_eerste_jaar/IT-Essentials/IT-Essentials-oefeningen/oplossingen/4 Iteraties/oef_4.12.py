familienaam = input("Geef de familienaam")
totaal_premie = 0
hoogste_premie = 0
while not (familienaam == "/" or familienaam == "*"):
    voornaam = input("Geef de voornaam: ")
    dienstjaren = int(input("Geef het aantal dienstjaren "))
    while dienstjaren > 40 or dienstjaren < 0:
        print("Fout!! Probeer opnieuw")
        dienstjaren = int(input("Geef het aantal dienstjaren "))
    if dienstjaren < 5:
        premie = 0
    else:
        premie = dienstjaren * 25

    totaal_premie += premie
    if premie > hoogste_premie:
        hoogste_premie = premie

    print("Familienaam:", familienaam)
    print("Voornaam:", voornaam)
    print("Aantal jaren dienst:", dienstjaren)
    print("Premie:", premie)
    familienaam = input("Geef de familienaam ")

print("Het totaal te betalen premie", totaal_premie)
print("De hoogste premie is", hoogste_premie)

