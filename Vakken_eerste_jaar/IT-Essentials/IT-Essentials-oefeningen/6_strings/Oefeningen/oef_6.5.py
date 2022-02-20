'''Een bepaald weekblad gunt zijn lezers graag een ontspannend weekendje uit, aan een schappelijke prijs. Schrijf een programma waarmee de lezer de prijs kan bepalen van een nachtje.
Via toetsenbord wordt het aantal volwassenen en het aantal kinderen ingegeven.
Vervolgens worden volgende gegevens via het toetsenbord ingevoerd: hotelcode (bestaat uit twee letters gevolgd door 4 cijfers), aantal sterren (getal van 1 (zeer simpel hotel) tot 5 (super-de-luxe hotel)) en kindercode ('A' t.e.m. 'Z' is toegelaten, controleer de invoer).
De invoer stopt als er voor hotelcode een / wordt ingegeven.

Maak een lijst met per hotel: het aantal sterren, de prijs per persoon per nacht, de prijs per kind per nacht en de totale prijs.

Het bepalen van de prijs per persoon dient in een functie te gebeuren. De prijs per persoon wordt als volgt berekend:

4- en 5- sterrenhotels kosten 60 €
3-sterrenhotels kosten 56 € (uitgezonderd: 3-sterrenhotels in Brussel (hotelcode begint met BR) en Antwerpen (hotelcode begint met AN) kosten eveneens 60 €)
2- en 1-sterrenhotels kosten 48 €
LET OP: Hilton hotels (hotelcode begint met HI) kunnen hun kamers niet aanbieden aan deze bodemprijs, en rekenen steeds 70€ aan.

De prijs per kind wordt als volgt berekend:

indien kindercode "A" is geldt: kinderen in 1- en 2-sterrenhotels zijn gratis, evenals in alle hotels die niet in Brussel gelegen zijn.
In alle andere gevallen betalen kinderen 50% van de prijs van een volwassene.
Dit programma geeft bijvoorbeeld volgende output:

HI1234***** 70.00 0.00 140.00
BR4568**    48.00 24.00 168.00
AN3216****  60.00 30.00 210.00
PN4444***   56.00 28.00 196.00               '''


def bereken_prijs_per_volwassene(hotelcode, aantal_sterren):
    if hotelcode[:1] == "HI":
        return 70
    elif aantal_sterren == 4 or aantal_sterren == 5:
        return 60
    elif aantal_sterren == 3 and hotelcode[:1] == 'BR' or hotelcode[:1] == 'AN':
        return 60
    elif aantal_sterren == 3:
        return 56
    else:
        return 48


def bereken_prijs_per_kind(kindercode, hotelcode, aantal_sterren, prijs_volwassene):
    if kindercode == "A":
        if aantal_sterren == 1 or aantal_sterren == 2 or hotelcode[:1] != "BE":
            return 0
    else:
        return prijs_volwassene * 0.5


def main():
    aantal_volwassenen = int(input("Geef het aantal volwassenen in "))
    aantal_kinderen = int(input("Geef het aantal kinderen in "))
    hotelcode = input("Geef de hotelcode in ")
    output = ""
    while hotelcode != "/":
        aantal_sterren = int(input("Geef het aantal sterren in "))
        aantal_sterren *= "*"
        kindercode = input("Geef de kindercode in ")
        while kindercode < "A" or kindercode > "Z":
            kindercode = input("Foute invoer de kindercode moet tussen A en Z liggen. Geef opnieuw in ")

        prijs_per_volwassene = bereken_prijs_per_volwassene(hotelcode, aantal_sterren)
        prijs_per_kind = bereken_prijs_per_kind(kindercode, hotelcode, aantal_sterren, prijs_per_volwassene)
        totale_prijs = prijs_per_kind * aantal_kinderen + prijs_per_volwassene * aantal_volwassenen
        output += "{:<6}{:<5} {:<6.2f} {:<6.2f} {:<6.2f}\n".format(hotelcode, aantal_sterren, prijs_per_volwassene,
                                                                   prijs_per_kind, totale_prijs)

        hotelcode = input("Geef de hotelcode in ")
    print(output)


if __name__ == '__main__':
    main()
