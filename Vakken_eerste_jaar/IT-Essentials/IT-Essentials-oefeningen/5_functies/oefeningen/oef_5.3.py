'''Schrijf een programma om het lidgeld voor een tennisclub te berekenen.
Voor elk lid worden volgende gegevens via het toetsenbord ingevoerd: naam, leeftijd, aantal kinderen ten laste, inkomen en het aansluitingsjaar.
De invoer eindigt wanneer voor de naam X of x wordt ingegeven.

Per lid moet de naam en het lidgeld afgedrukt worden. Het lidgeld wordt als volgt berekend:

normaal aanvangsgeld 100 € per jaar;
leden ouder dan 60 jaar: een vermindering van 15 €;
leden met kinderen een vermindering van 7.5 € per kind met een maximum van 35 €;
leden die meer dan 20 jaar lid zijn een vermindering van 12.5 €;
leden met een inkomen kleiner dan 7500 € per jaar een vermindering van 25 €.
De verminderingen mogen gecumuleerd worden maar het minimum lidgeld is 50 €. De berekening van het lidgeld gebeurt in een functie.'''


def berekening_lidgeld(leeftijd, aantal_kinderen, inkomen, aansluitingsjaar):
    aanvangsgeld = 100
    teller = 0
    if leeftijd > 60:
        lidgeld = aanvangsgeld - 15
    while aantal_kinderen >= 1:
        teller += 1
        lidgeld = aanvangsgeld - (7.5 * teller)
        if lidgeld < 65:
            lidgeld = 65
    if aansluitingsjaar < 2000:
        lidgeld = aanvangsgeld - 12.5
    if inkomen < 7500:
        lidgeld = aanvangsgeld - 25

    else:
        lidgeld = aanvangsgeld

    return lidgeld


def main():
    teller = 0
    naam = str(input("Geef de naam in: "))
    while not (naam == 'x' or naam == 'X'):
        leeftijd = int(input("Geef de leeftijd in "))
        aantal_kinderen = int(input("Geef het aantal kinderen ten laste in: "))
        inkomen = int(input("Geef de inkomen in: "))
        aansluitingsjaar = int(input("Geef het aansluitingsjaar in: "))

        print("Naam:", naam)
        print("Lidgeld:", berekening_lidgeld(leeftijd, aantal_kinderen, inkomen, aansluitingsjaar), "euro")

        naam = str(input("Geef de naam in: "))


if __name__ == "__main__":
    main()
