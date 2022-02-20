# geef via toetsenbord code en tijd in
# code 1= met de bus, 2=te voet, 3=met de fiets, 4= met de trein, 5 = met de auto, 0 om te eindigen
# tijd = tijd in min om van huis naar school te gaan
# bereken gemiddelde duur
# bereken de minimale tijd
# was dit met de bus, te voet, met de fiets, met de trein of met de auto
# percentage dat met de auto komt
# niet de code afdrukken R6 wel tekst

code = int(input("geef de code in "))
minimum = 120  # initialisatie op een grote waarde!
minimum_code = -1  # om te vermijden dat de interpreter foutmelding geeft bij afdrukken minimumcode
teller = 0  # aantal personen te tellen
som = 0  # som om de totale duur te berekenen
teller_auto = 0  # om aantal personen te tellen die met de auto komt
while code != 0:
    tijd = int(input("geef de tijd in"))
    teller += 1
    som += tijd
    if tijd < minimum:
        minimum = tijd
        minimum_code = code
    if code == 5:
        teller_auto += 1

    code = int(input("geef de code in "))
gemiddelde = som / teller  # GEMIDDELDE ALTIJD NA DE LUS
print("print de gemiddelde tijd is", gemiddelde)
print("de minimale tijd is", minimum)
print("dit was met vervoerscode", minimum_code)

if minimum_code == 1:
    vervoersmiddel = "met de bus"
elif minimum_code == 2:
    vervoersmiddel = "te voet"
elif minimum_code == 3:
    vervoersmiddel = "met de fiets"
elif minimum_code == 4:
    vervoersmiddel = "met de trein"
else:
    vervoersmiddel = "met de auto"

percentage_auto = teller_auto / teller * 100
print("het percentage dat met de auto komt:", percentage_auto)

