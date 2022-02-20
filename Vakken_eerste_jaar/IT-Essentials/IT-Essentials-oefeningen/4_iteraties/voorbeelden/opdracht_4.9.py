# bereken de gemiddelde leeftijd van 28 studenten
som = 0  # declaratie + initialisatie van u variabele
for i in range(28):
    leeftijd = int(input("geef de leeftijd van een student in "))
    som += leeftijd
gemiddelde = som / 28
print("de gemiddelde leeftijd is", gemiddelde)
