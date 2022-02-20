sterren = int(input("Geef het aantal sterren: "))
code = input("Geef code voor ontbijt in: ")
aantal_overnachtingen = int(input("Geef aantal overnachtingen in: "))
seizoen = input("Geef code van seizoen in: ")

if sterren == 1:
    prijs_overnachting = 30 * aantal_overnachtingen
elif sterren == 2 or sterren == 3:
    prijs_overnachting = 40 * aantal_overnachtingen
else:
    prijs_overnachting = 55 * aantal_overnachtingen

if code == 'O':
    prijs_maaltijd = prijs_overnachting * 0.2
elif code == 'H':
    prijs_maaltijd = prijs_overnachting * 0.5
elif code == 'V':
    prijs_maaltijd = prijs_overnachting * 0.6
else:
    prijs_maaltijd = prijs_overnachting * 0.6 + (80 * aantal_overnachtingen)

totale_prijs = prijs_overnachting + prijs_maaltijd

if seizoen == 'L' and (code == 'O' or code =='H'):
        totale_prijs *= 0.9

print("De totale prijs is:", totale_prijs)