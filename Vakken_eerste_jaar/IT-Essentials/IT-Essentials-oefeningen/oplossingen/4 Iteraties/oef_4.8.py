inschrijvingsnummer = int(input("Geef het inschrijvingsnummer: "))
snelste = 3 * 3600
aantal_uur = 0
snelste_nummer = 0
teller = 0
while inschrijvingsnummer >= 0:
    tijd = int(input("Geef de tijd in: "))
    if tijd < snelste:
        snelste = tijd
        snelste_nummer = inschrijvingsnummer
    if tijd > 3600:
        aantal_uur += 1
    teller += 1
    inschrijvingsnummer = int(input("Geef het inschrijvingsnummer: "))
percentage = aantal_uur / teller
print("Snelste renner is de renner met inschrijvingsnummer", snelste_nummer)
print("Het percentage van de renners dat er langer dan 1 uur over doet:", percentage)
