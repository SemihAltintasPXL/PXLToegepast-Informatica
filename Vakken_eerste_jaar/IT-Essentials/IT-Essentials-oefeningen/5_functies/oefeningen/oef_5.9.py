# We maken enkele functies die we kunnen gebruiken om onze reiskosten te berekenen:
#
# De eerste functie hotel_kosten heeft 1 parameter aantal_nachten. Het hotel kost € 140,50 per nacht. Iedere 3de nacht is gratis.
#
# Vervolgens maken we een functie vliegtuig_kosten waaraan we een string, stad, als argument meegeven.
# De functie geeft de prijs voor de heen- en terugreis afhankelijk van de locatie.
# Hieronder vind je de geldige bestemmingen en hun overeenkomstige prijzen (de prijzen zijn voor heen- en terugvlucht):
#
# Barcelona: 183
# Rome: 220
# Berlijn: 125
# Oslo: 450
# Maak daarna een functie huurauto_kosten. Deze functie voorziet 1 parameter: aantal_dagen. Bereken de kost voor het huren van een auto: de huurkost bedraagt €40 per dag.
# Indien je de auto meer dan 7 dagen huurt, krijg je €50 korting. Voor meer dan 3 dagen (maar minder dan 7) krijg je €20 korting.
#
# Tenslotte maak je een functie met de naam reis_kosten, de functie wordt aangeroepen met twee argumenten: stad en aantal_dagen.
# De functie reis_kosten geeft je de totale prijs van je reis (autoverhuur, hotelkosten en vluchten).
# Je kan de functie enkel aanroepen met 1 van bovenstaande steden, anders geef je een foutboodschap aan de gebruiker.
#
# Test je programma grondig!


def hotel_kosten(aantal_nachten):
    kost = (aantal_nachten - aantal_nachten // 3) * 140.50
    
    return kost


def vliegtuig_kosten(stad):
    if stad == "Barcelona":
        kost = 183
    elif stad == "Rome":
        kost = 220
    elif stad == "Berlijn":
        kost = 125
    else:  # if stad = oslo
        kost = 450

    return kost


def huurauto_kosten(aantal_dagen):
    huurkost_per_dag = 40
    huurkost = huurkost_per_dag * aantal_dagen
    if aantal_dagen > 7:
        huurkost -= 50
    elif aantal_dagen > 3 and aantal_dagen < 7:
        huurkost -= 20
    return huurkost


def reiskosten(stad, aantal_dagen, aantal_nachten):
    totale_prijs = hotel_kosten(aantal_nachten) + vliegtuig_kosten(stad) + huurauto_kosten(aantal_dagen)
    return totale_prijs


def main():
    stad = str(input("Welke stad? "))
    while not (stad == "Barcelona" or stad == "Rome" or stad == "Berlijn" or stad == "Oslo"):
        stad = str(input("Gelieve te kiezen uit de volgende steden: Barcelona , Rome , Berlijn , Oslo "))
    aantal_dagen = int(input("Aantal dagen? "))
    aantal_nachten = int(input("Aantal nachten? "))

    print("Hotelkosten:", hotel_kosten(aantal_nachten), "euro\nVliegtuig kosten:", vliegtuig_kosten(stad),
          "euro\nHuurauto kosten:", huurauto_kosten(aantal_dagen), "euro\nTotale reiskosten:",
          reiskosten(stad, aantal_dagen, aantal_nachten), "euro")


if __name__ == "__main__":
    main()
