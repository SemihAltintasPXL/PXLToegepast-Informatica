# opgave 4.2 met while ipv for. Bereken de gemiddelde leeftijd van 28 studenten

som = 0
teller = 0  # de hoeveelste keer de reeks instructies wordt uitgevoerd
while teller <= 28:
    leeftijd = int(input("geef je leeftijd in"))
    som += leeftijd
    teller += 1
gemiddelde = som / 28
print("de gemiddelde leeftijd is", gemiddelde)
