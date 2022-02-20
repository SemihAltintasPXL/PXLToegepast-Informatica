'''Prijsberekening vakantie

Invoer:

aantal sterren: 1 - 5
code: O (enkel ontbijt), H (half-pension), V (vol pension), A (all-inclusive)
aantal overnachtingen
seizoen: H (hoogseizoen), L (laagseizoen), T (tussenseizoen)
De prijs voor het verblijf wordt als volgt berekend:

voor een 1-sterrenhotel betaal je per nacht 30 euro
voor een 2-3-sterrenhotel betaal je per nacht 40 euro
voor een 4-5-sterrenhotel betaal je per nacht 55 euro
De prijs voor de maaltijden wordt als volgt berekend:

voor enkel ontbijt betaal je 20% van de overnachtingskosten
voor half-pension betaal je 50% van de overnachtingskosten
voor vol-pension betaal je 60% van de overnachtingskosten
LET OP: voor All-inclusive betaal je steeds (ongeacht het aantal sterren) bovenop de prijs voor vol-pension een vaste prijs van 80 euro per overnachting.

Er wordt een extra korting van 10% op de totaalprijs toegekend tijdens het laagseizoen voor de codes O en H.
 Geef de nodige gegevens in en druk de prijs van een vakantie voor 1 persoon af.'''

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

if seizoen == 'L' and (code == 'O' or code == 'H'):
    totale_prijs *= 0.9

print("De totale prijs is:", totale_prijs)
